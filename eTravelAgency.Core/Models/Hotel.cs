using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public string HotelName { get; set; }
        public string HotelAddress { get; set; }
        public float Rating { get; set; }
        public int TotalVisits { get; set; }
        public byte[] Picture { get; set; }

    }
}
