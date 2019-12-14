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
    public partial class CityDetailPage : ContentPage
    {

        private CityDetailViewModel viewModel = null;
        private readonly int _id;
        public CityDetailPage(int id)
        {
            InitializeComponent();
            _id = id;
            BindingContext = viewModel = new CityDetailViewModel();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            if (_id != 0)
            {
                await viewModel.Init(_id);
            }
        }

        private void Button_MakeReservation(object sender, EventArgs e)
        {
            Button button = sender as Button;
            int id = (int)button.BindingContext;

            

            var newMpage = new MainPage
            {
                Title="Offers",
                Master = new MenuPage(),
                Detail = new NavigationPage(new OffersPage(id))
            };
            Application.Current.MainPage = newMpage;
        }

        private void Hotel_Clicked(object sender, EventArgs e)
        {
            var button = sender as Button;
            int id = (int)button.BindingContext;

            var newMpage = new MainPage
            {
                Title = "Hotel Details",
                Master = new MenuPage(),
                Detail = new NavigationPage(new HotelDetailPage(id))
            };
            Application.Current.MainPage = newMpage;

        }
    }
}