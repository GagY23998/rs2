using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgencyMobileApp.Models
{
    public class RatingRequestModel
    {
        public int ReservationId { get; set; }
        public int HotelRating { get; set; }
        public int TransportRating { get; set; }
    }
}
