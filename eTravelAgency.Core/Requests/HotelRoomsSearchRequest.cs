using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.Core.Requests
{
    public class HotelRoomsSearchRequest
    {
        public int HotelId { get; set; }
        public int RoomTypeId { get; set; }
    }
}
