using eTravelAgency.Core.Requests;
using eTravelAgencyMobileApp.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class RegisterViewModel:BaseViewModel
    {
        private readonly APIService _userService = new APIService("user");
        private readonly APIService _roleService = new APIService("role");
        private byte[] _picture;
        public UserInsertRequest User { get; set; }
        public ICommand RegisterCommand { get; set; }
        public byte[] Picture { get { return _picture; } set { SetProperty(ref _picture,value); } }
        public RegisterViewModel()
        {
            User = new UserInsertRequest();
            RegisterCommand = new Command(async (object bindedObject) => await Register(bindedObject));
        }
        private async Task Register(object bindedObject)
        {
            var InsertRequest = (UserInsertRequest)bindedObject;

            var properties = InsertRequest.GetType().GetProperties();
            var strings = properties.Where(_ => _.PropertyType.Name == nameof(String)).Select(_=>(string)_.GetValue(InsertRequest)).ToList();

            InsertRequest.Picture = Picture;

            var role = (await _roleService.Get<List<RoleDTO>>(null)).FirstOrDefault(_=>_.Name=="User");
            InsertRequest.Roles = new List<int>();
            if (!strings.Any(mystring => string.IsNullOrEmpty(mystring)) || InsertRequest.Picture !=null) 
            {
                InsertRequest.Roles.Add(role.Id);
                var userDto = await _userService.Insert<UserDTO>(InsertRequest);
                if(userDto != null)
                {
                    await  Application.Current.MainPage.DisplayAlert("Info", "Successufully added", "OK");
                    await Application.Current.MainPage.Navigation.PushAsync(new LoginPage());
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Could not add new user", "OK");
                }
            }

           

        }
    }
}
