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
    public class CountryFavoritesService : 
        CRUDService<CountryFavorites,CountryFavoritesDTO,CountryFavoritesInsertRequest,CountryFavoritesInsertRequest,CountryFavoritesInsertRequest>,
        ICountryFavoritesService
    {
        public CountryFavoritesService(eTravelContext context,IMapper mapper):
            base(context,
                 mapper)
        {

        }

        public IEnumerable<CountryFavoritesDTO> Get(CountryFavoritesSearchRequest searchRequest)
        {
            throw new NotImplementedException();
        }
    }
}
