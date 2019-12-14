using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class HotelInsertRequest
    {
        [RegularExpression(".[^!@#$%^&*(),.?\":{}|<>]{4,20}")]
        public string HotelName { get; set; }
        [Required]
        public int CityId { get; set; }
        [RegularExpression(".[^!@#$%^&*(),.?\":{}|<>]{4,20}")]
        public string HotelAddress { get; set; }
        public float Rating { get; set; } = 0;
        public int TotalVisits { get; set; }
        public byte[] Picture { get; set; }
    }
}
