
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class HotelOfferInsertRequest
    {  
        [Required]
        public int HotelId { get; set; }
        [Required]
        public int Discount { get; set; } = 0;
        public float PricePerPerson { get; set; }
        public DateTime StarDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
        public byte[] ThumbnailImage { get; set; }
    }
}
