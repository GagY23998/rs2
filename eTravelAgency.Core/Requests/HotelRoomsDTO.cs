using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class HotelRoomsDTO
    {
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public float Price { get; set; }
        public bool Active { get; set; }
        public int NumberOfRooms { get; set; }
        public int Available { get; set; }
    }
}
