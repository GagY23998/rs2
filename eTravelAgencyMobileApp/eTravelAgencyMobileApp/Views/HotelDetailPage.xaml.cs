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
    public partial class HotelDetailPage : ContentPage
    {
        private HotelDetailViewModel viewModel = null;
        public HotelDetailPage(int? id=null)
        {
            InitializeComponent();
            BindingContext = viewModel = new HotelDetailViewModel(id.Value);
        }
        public HotelDetailPage()
        {
            InitializeComponent();
            BindingContext= viewModel = new HotelDetailViewModel();
        }
        protected override async void OnAppearing()
        {
            await viewModel.Init();
            base.OnAppearing();
        }
    }
}