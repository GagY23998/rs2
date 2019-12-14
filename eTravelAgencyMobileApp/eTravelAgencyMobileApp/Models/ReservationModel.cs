using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using eTravelAgency.Core;
using eTravelAgency.Core.Requests;

namespace eTravelAgencyMobileApp.Models
{
    public class ReservationModel
    {
        public HotelOfferModel HotelOffer { get; set; }
        public TransportOfferModel TransportOffer { get; set; }    
        public int NumberOfPersons { get; set; }
        public List<RoomTypeDTO> Rooms { get; set; }

    }
}
