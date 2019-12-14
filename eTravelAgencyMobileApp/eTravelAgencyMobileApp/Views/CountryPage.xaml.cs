using eTravelAgencyMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTravelAgencyMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CountryPage : ContentPage
    {
        CountryViewModel viewModel = null;
        public CountryPage(int id)
        {
            InitializeComponent();
            BindingContext = viewModel = new CountryViewModel(id);
        }
        public CountryPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new CountryViewModel();
        }
        protected override async void OnAppearing()
        {
            await viewModel.Init();
            base.OnAppearing();
        }

        private void See_City(object sender, EventArgs e)
        {
            var button = sender as Button;
            int id = (int)button.BindingContext;


            var mainPage = new MainPage()
            {
                Master = new MenuPage(),
                Detail = new NavigationPage(new CityDetailPage(id))
            };
            Application.Current.MainPage = mainPage;
        }
    }
}