using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class RatingSearchRequest
    {
        public int Id { get; set; }
        public string City { get; set; }
        public int HotelId { get; set; }
        public string Hotel { get; set; }
        public int TransportCompanyId { get; set; }
        public int Rating { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
