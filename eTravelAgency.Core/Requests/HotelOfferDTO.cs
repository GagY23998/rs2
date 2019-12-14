using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class HotelOfferDTO
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        public int Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public float PricePerPerson { get; set; }
        public bool IsActive { get; set; }
        public byte[] ThumbnailImage { get; set; }

    }
}
