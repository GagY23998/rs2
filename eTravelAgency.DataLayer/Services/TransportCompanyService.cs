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
    public class TransportCompanyService:
        CRUDService<TransportCompany,TransportCompanyDTO,TransportCompanyInsertRequest,TransportCompanyInsertRequest,TransportCompanySearchRequest>, ITransportCompanyService
    {
        public TransportCompanyService(eTravelContext context,IMapper mapper):
            base(context, mapper)
        {

        }

        //public void Insert(TransportCompanyInsertRequest InsertRequest)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
