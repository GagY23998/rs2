using eTravelAgency.Core.Requests;
using eTravelAgencyMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class ReservationDetailViewModel: BaseViewModel
    {

        private readonly APIService _hOfferService = new APIService("hoteloffer");
        private readonly APIService _hotelService = new APIService("hotel");
        private readonly APIService _hRoomService = new APIService("hotelrooms"); 
        private readonly APIService _tCompanyService = new APIService("transportcompany");
        private readonly APIService _tOfferService = new APIService("transportoffer");
        private readonly APIService _roomTypeService = new APIService("roomtype");
        private readonly APIService _userService = new APIService("user");
        private readonly APIService _reservationService = new APIService("reservation");

        private HotelOfferModel _hOffer;
        private TransportOfferModel _tOffer;
        private int _numOfPersons = 0;
        private int _numOfDays = 0;
        private float _totalPrice = 0;

        private readonly int _hOfferId;
        private readonly int _tOfferId;

        public ICommand SubmitReservationCommand { get; set; }

        public HotelOfferModel HotelOffer { get { return _hOffer; } set { SetProperty(ref _hOffer, value); } }
        public TransportOfferModel TransportOffer { get { return _tOffer; } set {SetProperty(ref _tOffer,value); } }
        public int NumberOfPersons { get { return _numOfPersons; } set { SetProperty(ref _numOfPersons, value); } }
        public int NumberOfDays { get { return _numOfDays; } set {SetProperty(ref _numOfDays,value); } }
        public float TotalPrice { get { return _totalPrice; } set { SetProperty(ref _totalPrice, value); } }
        //public ObservableCollection<RoomTypeModel> Rooms { get; set; }
        //= new ObservableCollection<RoomTypeModel>();

        public ReservationDetailViewModel()
        {
            HotelOffer = new HotelOfferModel();
            TransportOffer = new TransportOfferModel();
            SubmitReservationCommand = new Command(async (object context) => await MakeReservation(context));
        }
        public ReservationDetailViewModel(int hOfferId,int tOfferId)
        {
            _hOfferId = hOfferId;
            _tOfferId = tOfferId;
            HotelOffer = new HotelOfferModel();
            TransportOffer = new TransportOfferModel();
            SubmitReservationCommand = new Command(async (object context) => await MakeReservation(context));
        }



        public async Task Init()
        {
            try
            {

                var hOffer = await _hOfferService.GetById<HotelOfferDTO>(_hOfferId);
                var tOffer = await _tOfferService.GetById<TransportOfferDTO>(_tOfferId);
    
    
                var hotel = await _hotelService.GetById<HotelDTO>(hOffer.HotelId);
                var transportCompany = await _tCompanyService.GetById<TransportCompanyDTO>(tOffer.TransportCompanyId);
    
                HotelOffer = new HotelOfferModel { hOffer = hOffer, Name = hotel.HotelName };
                TransportOffer = new TransportOfferModel { tOffer = tOffer, Name = transportCompany.TransportCompanyName };
                //var hotelRoomsData = await _hRoomService.Get<List<HotelRoomsDTO>>(new HotelRoomsSearchRequest {HotelId = hotel.Id });
                //foreach (var hroom in hotelRoomsData)
                //{
                //    var roomTypeData = await _roomTypeService.GetById<RoomTypeDTO>(hroom.RoomTypeId );
                //    Rooms.Add(new RoomTypeModel { 
                //        RoomTypeId =roomTypeData.Id,
                //        HotelId = hroom.HotelId,
                //        RoomTypeName = roomTypeData.RoomTypeName,
                //        RoomDetails = roomTypeData.RoomDetails,
                //        NumberOfRooms = hroom.NumberOfRooms,
                //        Available = hroom.Available,
                //        NumberOfPeople = roomTypeData.NumberOfPeople,
                //        Price = hroom.Price
                //    });
                //}

            }catch(Exception e)
            {
                

            }

        }

        private async Task<ReservationDTO> MakeReservation(object context)
        {
            var reservationModel = (ReservationDetailViewModel)context;
            //var rooms = reservationModel.Rooms;
            //var roomtypes = rooms.Where(_ => _.OrderedRooms != 0).ToList();
            //float totalPrice,roomPrice = 0;
            //if (roomtypes.Count != 0)
            //{
            //    foreach (var room in roomtypes)
            //    {
            //        NumberOfPersons += (room.OrderedRooms * room.NumberOfPeople);
            //        roomPrice += (room.Price * room.OrderedRooms);
            //    }
            //}
            //totalPrice = roomPrice + reservationModel.TransportOffer.tOffer.Price;
          

            var user = (await _userService.Get<List<UserDTO>>(new UserSearchRequest {UserName= APIService.Username}))
                .FirstOrDefault(_=>_.UserName == APIService.Username);
            ReservationInsertRequest request = new ReservationInsertRequest()
            {
                UserId = user.Id,
                HotelOfferId = reservationModel.HotelOffer.hOffer.Id,
                TransportOfferId = reservationModel.TransportOffer.tOffer.Id,
                NumberOfPersons = NumberOfPersons,
                TotalPrice = TotalPrice,
                DateReserved = DateTime.Now,
                NumberOfDays = reservationModel.NumberOfDays
            };
            var result = await _reservationService.Insert<ReservationDTO>(request);
            if(result != null)
               {
                   var hotel = await _hotelService.GetById<HotelDTO>(reservationModel.HotelOffer.hOffer.HotelId);
                   var transport = await _tCompanyService.GetById<TransportCompanyDTO>(reservationModel.TransportOffer.tOffer.TransportCompanyId);
                   hotel.TotalVisits += request.NumberOfPersons;
                   transport.TotalReservations += request.NumberOfPersons;
            
                   var hotelUpdate = new HotelInsertRequest()
                   {
                       CityId = hotel.CityId,
                       HotelAddress = hotel.HotelAddress,
                       HotelName = hotel.HotelName,
                       TotalVisits = hotel.TotalVisits
                   };
                   await _hotelService.Update<HotelDTO>(hotel.Id, hotelUpdate);
                   var transportUpdate = new TransportCompanyInsertRequest
                   {
                       TransportTypeId = transport.TransportTypeId,
                       IsActive = transport.IsActive,
                       Picture = transport.Picture,
                       TransportCompanyName = transport.TransportCompanyName,
                       TotalReservations =transport.TotalReservations
                   };
                   await _tCompanyService.Update<TransportCompanyDTO>(transport.Id, transportUpdate);
                await Application.Current.MainPage.DisplayAlert("Info", "Successufully added reservation", "Ok");
            }
            else
            {
                await Application.Current.MainPage.DisplayAlert("Info", "Error occured while adding reservation, please check your inputs", "Ok");

            }
             
            return result;
        }

    }
}
