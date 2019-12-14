using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class HotelDTO
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public int TotalVisits { get; set; }
        public float Rating { get; set; }
        public byte[] Picture { get; set; }

    }
}
