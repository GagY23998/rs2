using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class AttractionDTO
    {
        public int Id { get; set; }
        public int CityId { get; set; }
        public string AttractionName { get; set; }
        public string AttractionDetails { get; set; }
        public byte[] Picture { get; set; }
    }
}
