using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class CountryDTO
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryDetails { get; set; }
        public byte[] Picture { get; set; }
    }
}
