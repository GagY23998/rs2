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
    public class CountryService: CRUDService<Country,CountryDTO,CountryInsertRequest,CountryInsertRequest,CountrySearchRequest>,ICountryService
    {
        public CountryService(eTravelContext context,IMapper mapper):base(context,mapper)
        {
               
        }
    }
}
