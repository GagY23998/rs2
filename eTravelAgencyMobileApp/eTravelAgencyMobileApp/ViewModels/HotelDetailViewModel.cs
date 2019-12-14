using eTravelAgency.Core.Requests;
using eTravelAgencyMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eTravelAgencyMobileApp.Helpers;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class HotelDetailViewModel:BaseViewModel
    {
        private APIService _hotelService = new APIService("hotel");
        private APIService _ratingService = new APIService("rating");
        private APIService _userService = new APIService("user");
     
        private int _hotelId;

        public HotelDetailViewModel()
        {

        }
        public HotelDetailViewModel(int hotelId)
        {
            _hotelId = hotelId;
        }

        private HotelDTO _hotel;
        public HotelDTO Hotel { get { return _hotel; } set {SetProperty(ref _hotel,value); } }

        public ObservableCollection<HotelDTO> RecommendedHotels { get; set; } = new ObservableCollection<HotelDTO>();
        public ObservableCollection<RatingModel> Reviews { get; set; } = new ObservableCollection<RatingModel>();
    



        public async Task Init()
        {
            var hotel = await _hotelService.GetById<HotelDTO>(_hotelId);
            Hotel = hotel;
            var ratingData = await _ratingService.Get<List<RatingDTO>>(new RatingSearchRequest { HotelId = hotel.Id });

            Recommender recommender = new Recommender(hotel.Id,hotel.CityId);

            var recHotels = await recommender.GetSimilarHotels();
            foreach (var recHotel in recHotels)
            {
                RecommendedHotels.Add(recHotel);
            }
            
            foreach (var item in ratingData)
            {
                var rating =
                new RatingModel
                {
                    UserName = (await _userService.GetById<UserDTO>(item.UserId)).UserName,
                    Rating = item.HotelRating,
                    RatingDate = item.RatingDate
                };
                Reviews.Add(rating);
            }
        }
    }
}
