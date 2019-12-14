using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Models
{
    public class HotelRooms
    {
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
        public int RoomTypeId { get; set; }
        public RoomType Room { get; set; }

        public float Price { get; set; }
    }
}
