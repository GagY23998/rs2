using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class HotelRoomsInsertRequest
    {
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
        public float Price { get; set; }
        public bool Active { get; set; }
        public int NumberOfRooms { get; set; }
    }
}
