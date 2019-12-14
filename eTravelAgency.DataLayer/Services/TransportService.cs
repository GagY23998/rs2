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
    public class TransportService : 
                 CRUDService<TransportCompany,
                             TransportCompanyDTO,
                             TransportCompanyInsertRequest,
                             TransportCompanyInsertRequest,
                             TransportCompanySearchRequest>,ITransportCompanyService
    {
        public TransportService(eTravelContext context,IMapper myMapper):
            base(context,myMapper)
        {

        }
    }
}
