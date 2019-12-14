using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class CountryInsertRequest
    {
        public string CountryName { get; set; }
        public string CountryDetails { get; set; }
        public byte[] Picture { get; set; }
    }
}
