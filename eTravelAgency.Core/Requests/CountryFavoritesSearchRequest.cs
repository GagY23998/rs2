﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class CountryFavoritesSearchRequest
    {
        public int UserId { get; set; }
        public int CountryId { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
