using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Models
{
    public class TransportCompany
    {
        public int Id { get; set; }
        public int TransportTypeId { get; set; }
        public TransportType TransportType { get; set; }
        public string TransportCompanyName { get; set; }
        public float Rating { get; set; }
        public int TotalReservations { get; set; }
        public byte[] Picture { get; set; }
        public bool IsActive { get; set; }

    }
}
