using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Models
{
    public class City
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public string ZipCode { get; set; }
        public byte[] Picture { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
