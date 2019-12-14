using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class RoomTypeDTO
    {
        public int Id { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomDetails { get; set; }
        public int NumberOfPeople { get; set; }
    }
}
