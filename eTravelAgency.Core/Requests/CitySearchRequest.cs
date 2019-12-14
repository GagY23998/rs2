using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class CitySearchRequest
    {
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public string ZipCode { get; set; }
    }
}
