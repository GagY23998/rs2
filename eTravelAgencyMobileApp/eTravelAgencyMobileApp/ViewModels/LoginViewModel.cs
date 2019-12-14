using eTravelAgency.Core.Requests;
using eTravelAgencyMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class LoginViewModel:BaseViewModel
    {
        private string _username;
        private string _password;
        private readonly APIService _service = new APIService("user");
        private readonly APIService _roomTypeservice = new APIService("RoomType");
        public LoginViewModel()
        {
            LoginCommand = new Command(async () => await Login());
        }

        private async Task Login()
        {
            APIService.Username = UserName;
            APIService.Password = Password;

            try
            {
                this.IsBusy = true;
                await _service.Get<dynamic>(null);
                Application.Current.MainPage = new MainPage();
            }
            catch (Exception ex)
            {
            }

        }

        public string UserName { get {return _username; } set {SetProperty(ref _username,value); } }
        public string Password { get { return _password; } set { SetProperty(ref _password, value); } }
        public ICommand LoginCommand { get; set; }
    }
}
