using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Models
{
    public class Reservation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int HotelOfferId { get; set; }
        public HotelOffer HotelOffer { get; set; }
        public int TransportOfferId { get; set; }
        public TransportOffer TransportOffer { get; set; }
        public int NumberOfPersons { get; set; }
        public DateTime DateReserved { get; set; }
        public DateTime StartTripDate { get; set; }
        public int NumberOfDays { get; set; }
        public float TotalPrice { get; set; }
        public bool Finished { get; set; }
        public bool Canceled { get; set; }
    }
}
