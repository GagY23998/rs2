using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class TransportCompanyDTO
    {
        public int Id { get; set; }
        public int TransportTypeId { get; set; }
        public string TransportCompanyName { get; set; }
        public int TotalReservations { get; set; }
        public float Rating { get; set; }
        public bool IsActive { get; set; }
        public byte[] Picture { get; set; }
    }
}
