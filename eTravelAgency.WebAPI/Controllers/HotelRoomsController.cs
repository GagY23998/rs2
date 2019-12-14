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
    public class HotelRoomsController : BaseController<HotelRooms,HotelRoomsDTO,HotelRoomsInsertRequest,HotelRoomsInsertRequest,HotelRoomsSearchRequest>
    {
        public HotelRoomsController(IHotelRoomsService service,IMapper mapper)
            :base(service,mapper)
        {

        }
    }
}