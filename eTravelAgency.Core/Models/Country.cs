﻿using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Models
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }
        public string CountryDetails { get; set; }
        public byte[] Picture { get; set; }
    }
}
