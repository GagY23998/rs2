using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class TransportOfferInsertRequest
    {
        public int TransportCompanyId { get; set; }
        public int CityId { get; set; }
        public byte[] ThumbnailImage { get; set; }
        public float Price { get; set; }
        public int Discount { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
