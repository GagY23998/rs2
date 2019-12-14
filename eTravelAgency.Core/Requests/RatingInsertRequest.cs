using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class RatingInsertRequest
    {
        public int UserId { get; set; }
        public int ReservationId { get; set; }
        public int HotelId { get; set; }
        public int TransportCompanyId { get; set; }
        public int TransportRating { get; set; }
        public int HotelRating { get; set; }
        public DateTime RatingDate { get; set; }

    }
}
