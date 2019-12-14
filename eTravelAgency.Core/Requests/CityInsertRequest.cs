using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class CityInsertRequest
    {

        public string CityName { get; set; }
        public string ZipCode { get; set; }
        public int CountryId { get; set; }
        public byte[] Picture { get; set; }
    }
}
