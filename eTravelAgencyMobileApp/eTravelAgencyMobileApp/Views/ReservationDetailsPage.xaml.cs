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
    public partial class ReservationDetailsPage : ContentPage
    {
        private ReservationDetailViewModel viewModel;
        public ReservationDetailsPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ReservationDetailViewModel();
        }
        public ReservationDetailsPage(int hOfferId,int tOfferId)
        {
            InitializeComponent();
            BindingContext = viewModel = new ReservationDetailViewModel(hOfferId,tOfferId);
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await viewModel.Init();
            tOffer_Stack.BindingContext = viewModel.TransportOffer;
        }

        private void myStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {


            var ButtonSender = sender as Stepper;
            var StackLayoutParent = (StackLayout)ButtonSender.Parent;
            var firstChild = (Label)StackLayoutParent.Children[0];
            var mySpan = (Span)firstChild.FormattedText.FindByName("mySpan");
            var text = mySpan.Text;
            mySpan.Text = e.NewValue.ToString();

        }

        private void Submit_Reservation(object sender, EventArgs e)
        {
            DisplayAlert("Info","this is event","Ok man");
        }

        private void NumberOfPersons_Changed(object sender, TextChangedEventArgs e)
        {
            if (viewModel != null)
            {
                var myEntry = sender as Entry;
                if (!string.IsNullOrEmpty(myEntry.Text))
                {
                    int numDays = (int.Parse(numDays_Label.Text));
                    numDays = numDays == 0 ? 1 : numDays;
                    float tdiscount = viewModel.TransportOffer.tOffer.Discount / 100f;
                    float hdiscount = viewModel.HotelOffer.hOffer.Discount / 100f;
                    viewModel.TotalPrice = (int.Parse(numPersons_Label.Text) * numDays * hdiscount)
                        + ((int.Parse(numPersons_Label.Text) * viewModel.TransportOffer.tOffer.Price) * tdiscount);
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        span_Price.Text = viewModel.TotalPrice.ToString();
                    });
                }
            }
        }
        private void NumberOfDays_Changed(object sender, TextChangedEventArgs e)
        {
            if (viewModel != null)
            {
                var myEntry = sender as Entry;
                if (!string.IsNullOrEmpty(myEntry.Text))
                {
                    viewModel.TotalPrice = (int.Parse(numPersons_Label.Text) * (int.Parse(numDays_Label.Text) * viewModel.HotelOffer.hOffer.PricePerPerson) * (viewModel.HotelOffer.hOffer.Discount / 100f))
                       + ((int.Parse(numPersons_Label.Text) * viewModel.TransportOffer.tOffer.Price) * (viewModel.TransportOffer.tOffer.Discount / 100f));
                    Device.BeginInvokeOnMainThread(() =>
                    {
                        span_Price.Text = viewModel.TotalPrice.ToString();
                    });
                }
            }
        }
    }
}