using AutoMapper;
using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using eTravelAgency.DataLayer.Data;
using eTravelAgency.DataLayer.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eTravelAgency.DataLayer.Services
{
    public class RatingService:CRUDService<Rating,RatingDTO,RatingInsertRequest,RatingInsertRequest,RatingSearchRequest>,IRatingService
    {
        public RatingService(eTravelContext context,IMapper mapper):
            base(context,mapper)
        {

        }
       
    }
}
