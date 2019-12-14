using eTravelAgency.Core.Requests;
using eTravelAgencyMobileApp.Models;
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
    public partial class MyReservationPage : ContentPage
    {
        private readonly APIService _reservationService = new APIService("reservation");
        private readonly APIService _tOfferService = new APIService("transportoffer");
        private readonly APIService _userService = new APIService("user");
        private readonly APIService _ratingService = new APIService("rating");
        MyReservationsViewModel viewModel = null;
        public MyReservationPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new MyReservationsViewModel();
        }



        protected override async void OnAppearing()
        {
            await viewModel.Init();
            base.OnAppearing();
        }

        private async void Reservation_Canceled(object sender, EventArgs e)
        {
            var button = sender as Button;
            var reservationId = (int)button.BindingContext;

            var reservation = await _reservationService.GetById<ReservationDTO>(reservationId);
            var tOffer = await _tOfferService.GetById<TransportOfferDTO>(reservation.TransportOfferId);
            if (reservation.Canceled)
            {
                await DisplayAlert("Info", "Reservation is already canceled", "OK");
            }
            if (reservation.StartTripDate != default(DateTime))
            {
                if(reservation.StartTripDate.Subtract(DateTime.Now).Days <7)
                await DisplayAlert("Info", "You can cancel reservation 7 days before trip", "OK");
            }
            else
            {
                var updateRequest = new ReservationInsertRequest
                {
                    HotelOfferId = reservation.HotelOfferId,
                    DateReserved = reservation.DateReserved,
                    Finished = reservation.Finished,
                    Canceled =true,
                    NumberOfPersons = reservation.NumberOfPersons,
                    TotalPrice = reservation.TotalPrice,
                    TransportOfferId = reservation.TransportOfferId,
                    UserId = reservation.UserId
                };
                var result = await _reservationService.Update<ReservationDTO>(reservation.Id, updateRequest);
                await DisplayAlert("Info", (result != null) ? "Successufully canceld reservation" : "Can't cancel reservation right now", "OK");
                Device.BeginInvokeOnMainThread(() =>
                {
                    var parent = (StackLayout)button.Parent.Parent;
                    var label = (Label)parent.Children[5];
                    label.Text = "Canceled: YES";
                });
            }

        }

        private void Submit_Rating(object sender, EventArgs e)
        {
            var myButton = sender as Button;
            var parent = (StackLayout)myButton.Parent;

            var stackLayout = (StackLayout)parent.Children[2];
            stackLayout.IsVisible = true;
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var myButton = sender as Button;
            int ID = (int)myButton.BindingContext;
            var parent = (StackLayout)myButton.Parent;

            int hotelRating = int.Parse(((Entry)parent.Children[0]).Text);
            int transportRating = int.Parse(((Entry)parent.Children[1]).Text);

            viewModel.MakeRatingCommand.Execute(new RatingRequestModel { ReservationId = ID, HotelRating = hotelRating, TransportRating = transportRating });

        }
    }
}
