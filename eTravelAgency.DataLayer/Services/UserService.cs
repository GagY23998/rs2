using AutoMapper;
using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using eTravelAgency.DataLayer.Data;
using eTravelAgency.DataLayer.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web.Helpers;

namespace eTravelAgency.DataLayer.Services
{
    public class UserService: CRUDService<User,UserDTO,UserInsertRequest,UserInsertRequest,UserSearchRequest>,IUserService
    {
        public UserService(eTravelContext context,IMapper mapper):
            base(context,
                 mapper)
        {

        }
        public static string GenerateSalt()
        {
            var buffer = new byte[16];
            (new RNGCryptoServiceProvider()).GetBytes(buffer);
            return Convert.ToBase64String(buffer);
        }
        public static string GenerateHash(string salt,string password)
        {
            byte[] src = Convert.FromBase64String(salt);
            byte[] bytes = Encoding.Unicode.GetBytes(password);
            byte[] dst = new byte[src.Length+bytes.Length];

            System.Buffer.BlockCopy(src, 0, dst, 0, src.Length);
            System.Buffer.BlockCopy(bytes, 0, dst, src.Length, bytes.Length);

            HashAlgorithm algorithm = HashAlgorithm.Create("SHA1");
            byte[] inArray = algorithm.ComputeHash(dst);
            return Convert.ToBase64String(inArray);

        }
        [Authorize(Roles ="Admin")]
        public override UserDTO Insert(UserInsertRequest InsertRequest)
        {
            if (InsertRequest.Password != InsertRequest.PasswordConfirmation) return null;
            var newEntity = MyMapper.Map<User>(InsertRequest);
            newEntity.PasswordSalt = GenerateSalt();
            newEntity.PasswordHash = GenerateHash(newEntity.PasswordSalt, InsertRequest.Password);
            _eTravelContext.Add(newEntity);
            _eTravelContext.SaveChanges();

            foreach (var item in InsertRequest.Roles)
            {
                _eTravelContext.UserRoles.Add(new UserRoles { RoleId = item, UserId = newEntity.Id });

            }

            _eTravelContext.SaveChanges();
            return MyMapper.Map<UserDTO>(newEntity);
        }

        public override UserDTO Update(int objectId, UserInsertRequest updateRequest)
        {
            if (updateRequest.Password != updateRequest.PasswordConfirmation) return null;

            User user = _eTravelContext.Users.Find(objectId);
            if (user == null) return null;
            _eTravelContext.Entry<User>(user).State = EntityState.Detached;

            var updateEntity = MyMapper.Map<User>(updateRequest);
            user = MyMapper.Map<User>(updateEntity);
            user.PasswordSalt = GenerateSalt();
            user.PasswordHash = GenerateHash(updateEntity.PasswordSalt, updateRequest.Password);
            user.Id = objectId;
            _eTravelContext.Users.Update(user);
            _eTravelContext.SaveChanges();
            if(updateRequest.Roles.Count != 0)
            {
                var userRoles = _eTravelContext.UserRoles.Where(_ => _.UserId == updateEntity.Id).ToList();
                _eTravelContext.UserRoles.RemoveRange(userRoles);
                _eTravelContext.SaveChanges();
                foreach (var role in updateRequest.Roles)
                {
                    _eTravelContext.UserRoles.Add(new UserRoles { UserId = updateEntity.Id, RoleId = role });
                    _eTravelContext.SaveChanges();
                }
            }
            return MyMapper.Map<UserDTO>(updateEntity);
        }


        public UserDTO Authenticate(string username, string password)
        {
            var user = _eTravelContext.Users.Include("UserRoles.Role").FirstOrDefault(_ => _.UserName == username);
            if (user != null)
            {
                var passwordHash = GenerateHash(user.PasswordSalt, password);
                if (passwordHash == user.PasswordHash) return MyMapper.Map<UserDTO>(user);
            }
            return null;
        }
    }
}
