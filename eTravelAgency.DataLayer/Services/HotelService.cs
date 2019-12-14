using AutoMapper;
using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using eTravelAgency.DataLayer.Data;
using eTravelAgency.DataLayer.Interfaces;
using eTravelAgency.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eTravelAgency.DataLayer.Services
{
    public class HotelService :
                 CRUDService<Hotel,
                             HotelDTO,
                             HotelInsertRequest,
                             HotelInsertRequest,
                             HotelSearchRequest>,IHotelService
    {
        public HotelService(eTravelContext eTravelContext,IMapper myMapper):
            base(eTravelContext,myMapper)
        {
        }

    }
}
