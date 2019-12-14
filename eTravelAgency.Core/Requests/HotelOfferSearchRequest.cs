using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class HotelOfferSearchRequest
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public float PricePerPerson { get; set; }
        public int Discount { get; set; }
        public bool IsActive { get; set; }
    }
}
