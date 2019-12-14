using eTravelAgencyMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class RoomItemViewModel:BaseViewModel
    {
        public RoomTypeModel _roomType;
        //public string RoomTypeName { get; set; }
        //public string RoomDetails { get; set; }
        //public int NumberOfPeople { get; set; }
        //public int NumberOfRooms { get; set; }
        //public int OrderedRooms { get; set; }
        //public float Price { get; set; }
        //public int Available { get; set; }



        public ICommand ChangedStepper;

        public RoomItemViewModel()
        {
            ChangedStepper = new Command(() => ChangeValue());
        }
        public RoomItemViewModel(RoomTypeModel roomType)
        {
            _roomType = roomType;
            ChangedStepper = new Command(() => ChangeValue());

        }

        private void ChangeValue()
        {
                       
        }


    }
}
