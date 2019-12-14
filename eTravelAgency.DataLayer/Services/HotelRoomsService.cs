using AutoMapper;
using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;
using eTravelAgency.DataLayer.Data;
using eTravelAgency.DataLayer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace eTravelAgency.DataLayer.Services
{
    public class HotelRoomsService:CRUDService<HotelRooms,
                                               HotelRoomsDTO,
                                               HotelRoomsInsertRequest,
                                               HotelRoomsInsertRequest,
                                               HotelRoomsSearchRequest>,IHotelRoomsService
    {
        public HotelRoomsService(eTravelContext context,IMapper mapper):
            base(context, mapper)
        {

        }


        //public HotelRoomsDTO Update(object objectId, HotelRoomsInsertRequest updateRequest)
        //{
        //    Type t = objectId.GetType();
        //    PropertyInfo hotel = t.GetProperty("hotelId");
        //    PropertyInfo room = t.GetProperty("roomId");

        //    HotelRooms myObject = _eTravelContext.HotelRooms.FirstOrDefault(_ => _.HotelId == (int)hotel.GetValue(objectId) &&
        //                                                                         (int)room.GetValue(objectId) == _.RoomTypeId);
        //    if (myObject == null)
        //    {
        //        return MyMapper.Map<HotelRoomsDTO>(updateRequest);
        //    }
        //    _eTravelContext.Entry<HotelRooms>(myObject).State = Microsoft.EntityFrameworkCore.EntityState.Detached;
        //    var map = MyMapper.Map<HotelRooms>(updateRequest);
            
        //    _eTravelContext.Update(map);
        //    _eTravelContext.SaveChanges();
        //    return MyMapper.Map<HotelRoomsDTO>(updateRequest);
           
        //}
    }
}
