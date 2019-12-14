using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using eTravelAgencyMobileApp.Models;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class MyReservationsViewModel: BaseViewModel
    {
        private readonly APIService _reservationService = new APIService("reservation");
        private readonly APIService _userService = new APIService("user");
        private readonly APIService _hOfferService = new APIService("hoteloffer");
        private readonly APIService _tOfferService = new APIService("transportoffer");
        private readonly APIService _hotelService = new APIService("hotel");
        private readonly APIService _tCompanyService = new APIService("transportcompany");
        private readonly APIService _ratingService = new APIService("rating");


        private string _fName;
        private string _lName;
        private byte[] _userPicture;

        public ICommand MakeRatingCommand { get; set; }
        public string FirstName { get { return _fName; } set { SetProperty(ref _fName, value); } }
        public string LastName { get { return _lName; } set { SetProperty(ref _lName, value); } }
        public byte[] Picture { get { return _userPicture; } set {SetProperty(ref _userPicture,value); } }
        public ObservableCollection<ReservationDetailModel> Reservations { get; set; } 
            = new ObservableCollection<ReservationDetailModel>();

        public MyReservationsViewModel()
        {
            MakeRatingCommand = new Command(async (object dynamicObject) => await MakeRating(dynamicObject));
        }

        public async Task Init()
        {
            var currentUser = (await _userService.Get<List<UserDTO>>(new UserSearchRequest
            {
                UserName = APIService.Username
            })).FirstOrDefault(_ => _.UserName == APIService.Username);

            var reservations = await _reservationService.Get<List<ReservationDTO>>(new ReservationSearchRequest { UserId = currentUser.Id});

                FirstName = currentUser.FirstName;
                LastName = currentUser.LastName;
                Picture = currentUser.Picture;
            foreach (var reservation in reservations)
            {
                var hOffer = await _hOfferService.GetById<HotelOfferDTO>(reservation.HotelOfferId);
                var hotel = await _hotelService.GetById<HotelDTO>(hOffer.Id);
                var tOffer = await _tOfferService.GetById<TransportOfferDTO>(reservation.TransportOfferId);
                var tCompany = await _tCompanyService.GetById<TransportCompanyDTO>(tOffer.TransportCompanyId);

                var date = DateTime.Now.Subtract(tOffer.EndDate);


                if (!reservation.Finished && !reservation.Canceled && date.Days == 0)
                {
                    // do nothing yet
                    reservation.Finished = true;
                    var updateRequest = new ReservationInsertRequest
                    {
                        UserId = reservation.UserId,
                        HotelOfferId = reservation.HotelOfferId,
                        TransportOfferId = reservation.TransportOfferId,
                        NumberOfPersons = reservation.NumberOfPersons,
                        TotalPrice = reservation.TotalPrice,
                        DateReserved = DateTime.Now,
                        NumberOfDays = reservation.NumberOfDays
                    };
                    var res = await _reservationService.Update<ReservationDTO>(reservation.Id, reservation);
                }

                var item = new ReservationDetailModel
                {
                    Id = reservation.Id,
                    TransportName = tCompany.TransportCompanyName,
                    HotelName = hotel.HotelName,
                    Canceled = reservation.Canceled ? "YES" : "NO",
                    Finished = reservation.Finished ? "YES" : "NO",
                    TripDate = reservation.StartTripDate!= default(DateTime)?reservation.StartTripDate.ToString("dd.MM.yyyy"):"Not set ",
                    DateReserved = reservation.DateReserved,
                    Price = reservation.TotalPrice
                };

                Reservations.Add(item);
            }



        }

        private async Task MakeRating(object dynamicObject)
        {

            try
            {


                RatingRequestModel myRequest = (RatingRequestModel)dynamicObject;

                int userID = (await _userService.Get<List<UserDTO>>(new UserSearchRequest { UserName = APIService.Username })).FirstOrDefault(_ => _.UserName == APIService.Username).Id;
                var newRating = new RatingInsertRequest
                {
                    HotelRating = myRequest.HotelRating,
                    TransportRating = myRequest.TransportRating,
                    RatingDate = DateTime.Now,
                    ReservationId = myRequest.ReservationId,
                    UserId = userID
                };
                var reservation = await _reservationService.GetById<ReservationDTO>(myRequest.ReservationId);
                
                if(reservation.StartTripDate != default(DateTime))
                {
                    if(reservation.StartTripDate > DateTime.Now)
                    {
                        await Application.Current.MainPage.DisplayAlert("Info","Trip has not happend yet","OK");
                        return;
                    }
                }


                var tOffer = await _tOfferService.GetById<TransportOfferDTO>(reservation.TransportOfferId);
                var hOffer = await _hOfferService.GetById<HotelOfferDTO>(reservation.HotelOfferId);

                var hotel = await _hotelService.GetById<HotelDTO>(hOffer.HotelId);
                var tCompany = await _tCompanyService.GetById<TransportCompanyDTO>(tOffer.TransportCompanyId);

                bool sameRatings = (await _ratingService.Get<List<RatingDTO>>(new RatingSearchRequest { })).Any(_=>_.HotelId == hotel.Id && tCompany.Id == _.TransportCompanyId
                                                                                                                                         && _.UserId == userID);
                if (sameRatings)
                {
                    await Application.Current.MainPage.DisplayAlert("Info","You can't rate same reservation again","OK");
                    return;
                }

                newRating.TransportCompanyId = tCompany.Id;
                newRating.HotelId = hotel.Id;


                var res = await _ratingService.Insert<RatingDTO>(newRating);

                if (res != null)
                {


                    var allHotelOffers = await _hOfferService.Get<List<HotelOfferDTO>>(new HotelOfferSearchRequest { HotelId = hotel.Id });
                    var allTransportOffers = await _tCompanyService.Get<List<TransportOfferDTO>>(new TransportOfferSearchRequest { TransportCompanyId = tCompany.Id });

                    float averageHotelRating = (float)(await _ratingService.Get<List<RatingDTO>>(new RatingSearchRequest { HotelId = hotel.Id })).Average(_ => _.HotelRating);
                    float averageTransportRating = (float)(await _ratingService.Get<List<RatingDTO>>(new RatingSearchRequest { TransportCompanyId = tCompany.Id })).Average(_ => _.TransportRating);

                    var hotelUpdateRequest = new HotelInsertRequest
                    {
                        HotelAddress = hotel.HotelAddress,
                        HotelName = hotel.HotelName,
                        CityId = hotel.CityId,
                        TotalVisits = hotel.TotalVisits,
                        Rating = averageHotelRating,
                        Picture = hotel.Picture
                    };
                    var transportUpdateRequest = new TransportCompanyInsertRequest
                    {
                        TransportCompanyName = tCompany.TransportCompanyName,
                        IsActive = tCompany.IsActive,
                        Picture = tCompany.Picture,
                        TransportTypeId = tCompany.TransportTypeId
                    };
                    var hotelResult = await _hotelService.Update<HotelDTO>(hotel.Id, hotelUpdateRequest);
                    var transportResult = await _tCompanyService.Update<TransportCompanyDTO>(tCompany.Id, transportUpdateRequest);
                    if (hotelResult != null && transportResult != null)
                    {
                        await Application.Current.MainPage.DisplayAlert("INFO", "Successufully added Rating!", "OK");
                    }
                    else {

                        await Application.Current.MainPage.DisplayAlert("INFO", "Error adding Rating!", "OK");
                    }
                }

            }
            catch (Exception)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Make sure that all inputs are correct", "OK");
            }
        }
    }
}
