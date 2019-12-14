using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgencyMobileApp.Models
{
    public class CityModel
    {
        public List<AttractionDTO> Attractions { get; set; }
        public CityDTO City { get; set; }
        public byte[] ThumbnailImage { get; set; }

    }
}
