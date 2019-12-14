﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eTravelAgency.DataLayer.Interfaces;
using eTravelAgency.Model.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace eTravelAgency.WebAPI.Helpers
{
   public interface IBaseInterface<Entity,EntityDTO,EntityInsertRequest,EntityUpdateRequest,EntitySearchRequest>
        where Entity: class,new()
        where EntityDTO: class,new()
        where EntityInsertRequest: class,new()
        where EntityUpdateRequest: class
    {
        ActionResult<IEnumerable<EntityDTO>> Get(EntitySearchRequest searchRequest);
        ActionResult<EntityDTO> Get(int id);
        ActionResult<EntityDTO> Post([FromQuery]EntityInsertRequest insertRequest);
        ActionResult<EntityDTO> Put(int Id,[FromQuery]EntityUpdateRequest updateRequest);
      //  ActionResult<IEnumerable<EntityDTO>> GetAll();
    }
}
