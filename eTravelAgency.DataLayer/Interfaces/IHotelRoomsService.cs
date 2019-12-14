using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgency.DataLayer.Interfaces
{
    public interface IHotelRoomsService: 
        ICRUDService<HotelRooms,HotelRoomsDTO,HotelRoomsInsertRequest,HotelRoomsInsertRequest,HotelRoomsSearchRequest>
    {
    }
}
