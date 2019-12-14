using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class TransportCompanyInsertRequest
    {
        [RegularExpression(".[^!@#$%^&*(),.?\":{}|<>]{4,20}")]
        public string TransportCompanyName { get; set; }
        [Required]
        public int TransportTypeId { get; set; }
        public int TotalReservations { get; set; }
        [Required]
        public bool IsActive { get; set; }
        public byte[] Picture { get; set; }

    }
}
