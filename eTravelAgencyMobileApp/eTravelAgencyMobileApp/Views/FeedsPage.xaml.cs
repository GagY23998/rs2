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
    public partial class FeedsPage : ContentPage
    {
        FeedViewModel viewModel = null;
        public FeedsPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new FeedViewModel();
        }
        protected override async void OnAppearing()
        {
            await viewModel.Init();
            base.OnAppearing();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            int id = (int)clickedButton.BindingContext;
            var mainPage = new MainPage()
            {
                Master = new MenuPage(),
                Detail = new NavigationPage(new CountryPage(id))
            };
            Application.Current.MainPage = mainPage;
        }
        private void Company_Clicked(object sender,EventArgs e)
        {


            Button mybutton = sender as Button;
            int id = (int)mybutton.BindingContext;
            var mainPage = new MainPage()
            {
                Master = new MenuPage(),
                Detail = new NavigationPage(new TCompanyDetailPage(id))
            };
            Application.Current.MainPage = mainPage;


        }
    }
}