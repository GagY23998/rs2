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
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }
        private void MoveTo_RegisterPage(object sender,EventArgs e)
        {
            var mainPage = new MainPage()
            {
                Master = new MenuPage(),
                Detail = new NavigationPage(new RegisterPage())
            };
            Application.Current.MainPage = mainPage;
        }
    }
}