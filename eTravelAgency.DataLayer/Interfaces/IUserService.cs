using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.DataLayer.Interfaces
{
    public interface IUserService: ICRUDService<User,UserDTO,UserInsertRequest,UserInsertRequest,UserSearchRequest>
    {
        UserDTO Authenticate(string username, string password);
    }
}
