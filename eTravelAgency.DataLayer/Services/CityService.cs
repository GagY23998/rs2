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
    public class CityService: CRUDService<City,CityDTO,CityInsertRequest,CityInsertRequest,CitySearchRequest>,ICityService
    {
        public CityService(eTravelContext context,IMapper mapper) :
            base(context,mapper)
        {
                
        }
    }
}
