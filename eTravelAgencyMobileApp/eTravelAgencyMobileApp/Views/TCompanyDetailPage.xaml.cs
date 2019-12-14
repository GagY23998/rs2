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
    public partial class TCompanyDetailPage : ContentPage
    {

        TransportDetailViewModel viewModel = null;

        public TCompanyDetailPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new TransportDetailViewModel();
        }
        public TCompanyDetailPage(int id)
        {
            InitializeComponent();
            BindingContext = viewModel = new TransportDetailViewModel(id);
        }
        protected override async void OnAppearing()
        {
            await viewModel.Init();
            base.OnAppearing();

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button button = sender as Button;
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