using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class RatingDTO
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int HotelId { get; set; }
        public int TransportCompanyId { get; set; }
        public int TransportRating { get; set; }
        public int HotelRating { get; set; }
       // public string ReviewComments { get; set; }
        public DateTime RatingDate { get; set; }
    }
}
