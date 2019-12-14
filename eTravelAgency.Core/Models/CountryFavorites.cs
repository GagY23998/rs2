using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Models
{
    public class CountryFavorites
    {
        public int UserId { get; set; }
        public int CountryId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
