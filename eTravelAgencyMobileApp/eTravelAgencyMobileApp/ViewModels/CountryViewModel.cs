using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class CountryViewModel:BaseViewModel
    {

        private readonly APIService _countryService = new APIService("country");
        private readonly APIService _cityService = new APIService("city");
        private int _countryId;
        private CountryDTO _country;

        public CountryDTO Country { get { return _country; } set { SetProperty(ref _country, value); } }
        public ObservableCollection<CityDTO> Cities { get; set; }
        = new ObservableCollection<CityDTO>();

        public CountryViewModel()
        {

        }
        public CountryViewModel(int countryId)
        {
            _countryId = countryId;
        }

        public async Task Init()
        {

            CountryDTO country = null;
            List<CityDTO> cities = null;

            if(_countryId != 0)
            {
                country = await _countryService.GetById<CountryDTO>(_countryId);
                Country = country;
                cities = await _cityService.Get<List<CityDTO>>(new CitySearchRequest { CountryId = country.Id });

            }
            else
            {
                cities = await _cityService.Get<List<CityDTO>>(null);
            }
            foreach (var city in cities)
            {
                Cities.Add(city);
            }
        }
    }
}
