using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using eTravelAgency.DataLayer.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eTravelAgency.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttractionController : BaseController<Attraction,AttractionDTO,AttractionInsertRequest,AttractionInsertRequest,AttractionSearchRequest>
    {
        public AttractionController(IAttractionService service,IMapper mapper):base(service,mapper)
        {

        }
    }
}