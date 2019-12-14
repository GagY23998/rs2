using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using eTravelAgency.DataLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTravelAgency.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoomTypeController : BaseController<RoomType, RoomTypeDTO, RoomTypeInsertRequest, RoomTypeInsertRequest, RoomTypeSearchRequest>
    {
        public RoomTypeController(IRoomTypeService service, IMapper myMapper)
            : base(service, myMapper)
        {
            
        }
    }
}