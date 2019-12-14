using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class HotelSearchRequest
    {
        public int CityId { get; set; }
        public int HotelId { get; set; }
        public string HotelName { get; set; }
    }
}
