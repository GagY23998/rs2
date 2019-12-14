using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgencyMobileApp.Models
{
    public class ReservationDetailModel
    {
        public int Id { get; set; }
        public string HotelName { get; set; }
        public string TransportName { get; set; }
        public DateTime DateReserved { get; set; }
        public string TripDate { get; set; }

        public float Price { get; set; }
        public string Finished { get; set; }
        public string Canceled { get; set; }
    }
}
