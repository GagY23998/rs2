using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Models
{
    public class TransportOffer
    {
        public int Id { get; set; }
        public int TransportCompanyId { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public byte[] ThumbnailImage { get; set; }
        public TransportCompany TransportCompany { get; set; }
        public float Price { get; set; }
        public int Discount { get; set; }
        public DateTime StartDate { get; set; }//Trip start date
        public DateTime EndDate { get; set; }// Trip end date
        public bool IsActive { get; set; }
    }
}
