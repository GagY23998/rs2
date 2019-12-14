using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class CityDetailViewModel :BaseViewModel
    {

        private readonly APIService _cityService = new APIService("city");
        private readonly APIService _hotelService = new APIService("hotel");
        private readonly APIService _attrService = new APIService("attraction");

        private CityDTO _city;
        private int _totalVisits;


        public CityDTO  City { get { return _city; } set { SetProperty(ref _city, value); } }
        public int TotalVisits { get {return _totalVisits; } set { SetProperty(ref _totalVisits, value); } }
        public ObservableCollection<AttractionDTO> Attractions { get; set; }
        = new ObservableCollection<AttractionDTO>();
        public ObservableCollection<HotelDTO> Hotels { get; set; }
        = new ObservableCollection<HotelDTO>();


        public async Task Init(object objectId)
        {

            City = await _cityService.GetById<CityDTO>((int)objectId);
            var attrData = await _attrService.Get<List<AttractionDTO>>(new AttractionSearchRequest { CityId=City.Id});
            foreach (var item in attrData)
            {
                Attractions.Add(item);
            }

            var hotelData = await _hotelService.Get<List<HotelDTO>>(new HotelSearchRequest { CityId=City.Id });
            foreach (var item in hotelData)
            {
                Hotels.Add(item);
                TotalVisits += item.TotalVisits;
            }
        }


    }
}
