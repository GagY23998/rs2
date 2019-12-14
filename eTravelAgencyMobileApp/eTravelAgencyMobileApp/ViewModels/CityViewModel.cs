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
    public class CityViewModel
    {

        private readonly APIService _cityService = new APIService("city");
       
        public ObservableCollection<CityModel> CityList { get; set; } = new ObservableCollection<CityModel>();
        public CityViewModel()
        {
            InitCommand = new Command(async () => await Init());
        }

        public ICommand InitCommand { get; set; }

        public async Task Init()
        {
            var cityData = await _cityService.Get<List<CityDTO>>(null);
           
            foreach (var city in cityData)
            {
                CityList.Add(new CityModel
                {
                    City = city
                });
            }
        }

    }
}
