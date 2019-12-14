using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class ReservationSearchRequest
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int HotelOfferId { get; set; }
        public int TransportOfferId { get; set; }
        public int NumberOfPersons { get; set; }
        public int NumberOfDays { get; set; }
        public int FromPersons { get; set; }
        public int ToPersons { get; set; }
        public int FromDays { get; set; }
        public int ToDays { get; set; }
        public DateTime DateReserved { get; set; }
        public DateTime FromDate { get; set; }
        public DateTime ToDate { get; set; }
        public float FromPrice { get; set; }
        public float ToPrice { get; set; }
        public bool Canceled { get; set; }
    }
}
