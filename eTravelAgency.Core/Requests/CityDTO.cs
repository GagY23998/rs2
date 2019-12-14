using eTravelAgency.Core.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class CityDTO
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string CityName { get; set; }
        public string ZipCode { get; set; }
        public byte[] Picture { get; set; }
    }
}
