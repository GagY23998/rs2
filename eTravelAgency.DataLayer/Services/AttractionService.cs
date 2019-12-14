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
    public class AttractionService:
        CRUDService<Attraction,AttractionDTO,AttractionInsertRequest,AttractionInsertRequest,AttractionSearchRequest>,IAttractionService
    {
        public AttractionService(eTravelContext context,IMapper mapper)
            :base(context,mapper)
        {

        }
    }
}
