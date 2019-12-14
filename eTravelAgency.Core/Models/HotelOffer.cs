using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Models
{
    public class HotelOffer
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime ArrivalDate { get; set; }
        public float PricePerPerson { get; set; }
        public int Discount { get; set; }
        public bool IsActive { get; set; }
        public byte[] ThumbnailImage { get; set; }
    }
}
