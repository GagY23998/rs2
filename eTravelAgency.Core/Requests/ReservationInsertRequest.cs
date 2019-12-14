using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class ReservationInsertRequest
    {
        public int UserId { get; set; }
        public int HotelOfferId { get; set; }
        public int TransportOfferId { get; set; }
        public DateTime StartTripDate { get; set; }

        [Required]
        public int NumberOfDays { get; set; }
        [Required]
        public int NumberOfPersons { get; set; }
        [Required]
        public DateTime DateReserved { get; set; }
        [Required]
        public float TotalPrice { get; set; }
        public bool Finished { get; set; }
        public bool Canceled { get; set; }
    }
}
