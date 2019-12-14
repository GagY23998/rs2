using eTravelAgencyMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace eTravelAgencyMobileApp.Models
{
    public class RoomTypeModel:BaseViewModel
    {
        private int _orderedRooms = 0;

        public int RoomTypeId { get; set; }
        public int HotelId { get; set; }
        public string RoomTypeName { get; set; }
        public string RoomDetails { get; set; }
        public int NumberOfPeople { get; set; }
        public int NumberOfRooms { get; set; }
        public int OrderedRooms { get { return _orderedRooms; } set { SetProperty(ref _orderedRooms, value); OnPropertyChanged("OrderedRooms"); } }
        public float Price { get; set; }
        public int Available { get; set; }
    }
}
