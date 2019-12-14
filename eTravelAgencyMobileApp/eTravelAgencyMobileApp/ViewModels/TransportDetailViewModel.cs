using eTravelAgency.Core.Requests;
using eTravelAgencyMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class TransportDetailViewModel:BaseViewModel
    {

        private readonly APIService _tCompanyService = new APIService("transportcompany");
        private readonly APIService _ratingService = new APIService("rating");
        private readonly APIService _userService = new APIService("user");
        private readonly APIService _cityService = new APIService("city");
        private readonly APIService _tOfferService = new APIService("transportoffer");

        private int _tranportId;
        private UserDTO _user;
        private TransportCompanyDTO _tCompany;
        public TransportCompanyDTO TCompany { get { return _tCompany; } set{ SetProperty(ref _tCompany, value); } }
        public UserDTO User { get { return _user; } set { SetProperty(ref _user, value); } }

      
        public ObservableCollection<CityDTO> Cities { get; set; }
        = new ObservableCollection<CityDTO>();
        public ObservableCollection<RatingModel> Reviews { get; set; }
        = new ObservableCollection<RatingModel>();

        public TransportDetailViewModel(int id)
        {
            _tranportId = id;
            
        }
        public TransportDetailViewModel()
        {
           
        }

        public async Task Init()
        {
            var transport = await _tCompanyService.GetById<TransportCompanyDTO>(_tranportId);
            TCompany = transport;

            var tOffers = (await _tOfferService.Get<List<TransportOfferDTO>>(new TransportOfferSearchRequest {TransportCompanyId= transport.Id }));
            foreach (var offer in tOffers)
            {
                var city = await _cityService.GetById<CityDTO>(offer.CityId);
                Cities.Add(city);
            }


            var ratingData = await _ratingService.Get<List<RatingDTO>>(new RatingSearchRequest {TransportCompanyId = transport.Id });
            foreach (var item in ratingData)
            {
                var model = new RatingModel
                {
                    UserName = (await _userService.GetById<UserDTO>(item.UserId)).UserName,
                    Rating = item.TransportRating,
                    RatingDate = item.RatingDate
                };
                Reviews.Add(model);
            }

        }
    
        
    }
}
