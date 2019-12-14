using eTravelAgency.Core.Requests;
using eTravelAgencyMobileApp.Models;
using eTravelAgencyMobileApp.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTravelAgencyMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class OffersPage : ContentPage
    {
        OffersViewModel viewModel = null;

        
        public OffersPage(int? id = null)
        {
            InitializeComponent();
            BindingContext = viewModel = new OffersViewModel(id);
        }
        protected override async void OnAppearing()
        {
            await viewModel.Init();
            base.OnAppearing();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            var hOffer = hOffer_Collection.SelectedItem as HotelOfferModel;
            var tOffer = tOffer_Collection.SelectedItem as TransportOfferModel;

            if (hOffer == null || tOffer == null)
            {
                await DisplayAlert("Error", "Can't proceed with nonselected offers", "OK, Got It!");
            }
            else
            {
                var hotel = await new APIService("hotel").GetById<HotelDTO>(hOffer.hOffer.HotelId);
                if(hotel.CityId != tOffer.tOffer.CityId)
                {
                    await DisplayAlert("Info", "Offers can't have different city locations and destinations", "OK");
                    return; 
                }

                MainPage frm = new MainPage()
                {
                    Master = new MenuPage(),
                    Detail = new NavigationPage(new ReservationDetailsPage(hOffer.hOffer.Id, tOffer.tOffer.Id))
                };
                Application.Current.MainPage = frm;
            }
        }

    }
}