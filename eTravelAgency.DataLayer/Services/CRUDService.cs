using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eTravelAgency.DataLayer.Data;
using eTravelAgency.DataLayer.Interfaces;
using AutoMapper;
using System.Reflection;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using System.Linq.Dynamic.Core;
using eTravelAgency.Core.Helpers;

namespace eTravelAgency.DataLayer.Services
{
    public class CRUDService<Entity, EntityDTO, InsertRequest, UpdateRequest, SearchRequest> :
                 ICRUDService<Entity, EntityDTO, InsertRequest, UpdateRequest, SearchRequest>
                     where Entity : class, new()
                     where EntityDTO : class, new()
                     where InsertRequest : class, new()
                     where UpdateRequest : class
                     where SearchRequest : class,new()
    {
        public CRUDService(eTravelContext eTravelContext, IMapper myMapper)
        {
            _eTravelContext = eTravelContext;
            MyMapper = myMapper;
        }

        public eTravelContext _eTravelContext { get; }
        public IMapper MyMapper { get; }
        public EntityDTO Delete(int Id)
        {
            var myObject = _eTravelContext.Find<Entity>(Id);
            _eTravelContext.Remove(myObject);
            _eTravelContext.SaveChanges();
            return MyMapper.Map<EntityDTO>(myObject);
        }
       
        private object GetDefaultTypeValue(Type myType)
        {
            if(myType.IsValueType && Nullable.GetUnderlyingType(myType) == null)
            {
                return Activator.CreateInstance(myType);
            }
            return null;
        }

        private IQueryable<Entity> SearchWhereClause(IQueryable<Entity> query,SearchRequest searchObject,string childProperty = "")
        {

            var properties = searchObject.GetType().GetProperties();

            foreach (var property in properties)
            {
                var myentity = Activator.CreateInstance<Entity>();
                if (!myentity.GetType().GetProperties().Select(_ => _.Name).Contains(property.Name)){
                    continue;
                }


                var propertyType = property.PropertyType;
                var defaultVal = this.GetDefaultTypeValue(propertyType);
                var propertyValue = property.GetValue(searchObject, null);

                if (propertyValue == null) continue;
                if(propertyType == typeof(DateTime) && ((DateTime)propertyValue).Hour!=0)
                {
                    propertyValue = (object)((DateTime)propertyValue).AddHours(-1);
                }
                    if (propertyValue.Equals(defaultVal))
                    {
                        continue;
                    }
                    var propertyName = childProperty != "" ? $"{childProperty}.{property.Name}" : property.Name;

                    
                    var value =property.PropertyType == typeof(string) ? $"\"{property.GetValue(searchObject,null)}\"":property.GetValue(searchObject,null);

                    query = query.Where($"{property.Name}={value}");
                }

                return query;
        }



        public EntityDTO Get(int id)
        {
            var myObject = _eTravelContext.Find<Entity>(id);
            return MyMapper.Map<EntityDTO>(myObject);
        }
        public IEnumerable<EntityDTO> GetAll()
        {
            var myObjects = _eTravelContext.Set<Entity>().ToList();
            return MyMapper.Map<List<EntityDTO>>(myObjects);
        }
        
        public virtual IEnumerable<EntityDTO> Get(SearchRequest searchRequest)
        {
            var myQuery = _eTravelContext.Set<Entity>().AsQueryable();

            myQuery = SearchWhereClause(myQuery, searchRequest);

            //if (myQuery.Count() == 0)
            //{
            //    return MyMapper.Map<IEnumerable<EntityDTO>>(_eTravelContext.Set<Entity>().ToList());
            //}
            var myResult = myQuery.ToList();
           
            var returnObject = MyMapper.Map<IEnumerable<EntityDTO>>(myResult);
            return returnObject;
        }

        public virtual EntityDTO Insert(InsertRequest InsertRequest)
        {
            var myObject = MyMapper.Map<InsertRequest,Entity>(InsertRequest);
            try
            {
                _eTravelContext.Add(myObject);
                _eTravelContext.SaveChanges();
            }catch(Exception e)
            {
                return null;
            }

            return MyMapper.Map<EntityDTO>(myObject);
        }
        public virtual EntityDTO Update(int objectId,UpdateRequest updateRequest)
        {
            Entity myObject = _eTravelContext.Find<Entity>(objectId);
            if (myObject == null)
            {
                return MyMapper.Map<EntityDTO>(updateRequest);
            }
            _eTravelContext.Entry<Entity>(myObject).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
            var map = MyMapper.Map<Entity>(updateRequest);
            map.GetType().GetProperty("Id").SetValue(map,objectId);
            _eTravelContext.Update(map);
            _eTravelContext.SaveChanges();
            return MyMapper.Map<EntityDTO>(updateRequest);
        }
    }
}
