using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class AttractionInsertRequest
    {
        public int CityId { get; set; }
        [Required(AllowEmptyStrings =false)]
        public string AttractionName { get; set; }
        [Required(AllowEmptyStrings = false)]
        public string AttractionDetails { get; set; }
        public byte[] Picture { get; set; }
    }
}
