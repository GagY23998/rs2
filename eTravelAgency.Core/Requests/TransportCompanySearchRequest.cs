using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class TransportCompanySearchRequest
    {
        public int CityId { get; set; }
        public string TransportCompanyName { get; set; }
        public int TotalReservations { get; set; }

    }
}
