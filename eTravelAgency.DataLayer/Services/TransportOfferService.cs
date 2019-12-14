using AutoMapper;
using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using eTravelAgency.DataLayer.Data;
using eTravelAgency.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.DataLayer.Services
{
    public class TransportOfferService:
        CRUDService<TransportOffer,TransportOfferDTO,TransportOfferInsertRequest,TransportOfferInsertRequest,TransportOfferSearchRequest>
        ,ITransportOfferService
    {
        public TransportOfferService(eTravelContext context,IMapper mapper):base(context,mapper)
        {

        }
    }
}
