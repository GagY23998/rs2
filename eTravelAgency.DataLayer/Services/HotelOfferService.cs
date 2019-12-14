using AutoMapper;
using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using eTravelAgency.DataLayer.Data;
using eTravelAgency.DataLayer.Interfaces;
using eTravelAgency.Model.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.DataLayer.Services
{
    public class HotelOfferService:
                 CRUDService<HotelOffer,
                             HotelOfferDTO,
                             HotelOfferInsertRequest,
                             HotelOfferInsertRequest,HotelOfferSearchRequest>,IHotelOfferService
    {
        public HotelOfferService(eTravelContext context,IMapper myMapper):base(context,myMapper)
        {

        }
    }
}
