using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class RoomTypeSearchRequest
    {
        public int Id { get; set; }
        public string RoomTypeName { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
