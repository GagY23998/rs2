
using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Models
{
    public class Rating
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int TransportCompanyId { get; set; }
        public TransportCompany TransportCompany { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int TransportRating { get; set; }
        public int HotelRating { get; set; }
        public DateTime RatingDate { get; set; }    

    }
}
