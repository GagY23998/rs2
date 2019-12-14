using eTravelAgencyMobileApp.ViewModels;
using Plugin.Media;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace eTravelAgencyMobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        private RegisterViewModel viewModel = null;
        public RegisterPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new RegisterViewModel();
        }

        private async void Upload_Image(object sender, EventArgs e)
        {
            var media = CrossMedia.Current;
            var file = await media.PickPhotoAsync();

            ImageSource myImage = ImageSource.FromStream(() => file.GetStream());
            

            StreamImageSource source = (StreamImageSource)myImage;
            using (var ms = new MemoryStream())
            {
                var res = await source.Stream(CancellationToken.None);
                res.CopyTo(ms);
                viewModel.Picture = ms.ToArray();
            }

            Device.BeginInvokeOnMainThread(() =>
                {
                    img.Source = myImage;
                    img.Aspect = Aspect.AspectFit;
                });

        }
        private void GoTo_LoginPage(object sender,EventArgs e)
        {
            var mainPage = new MainPage()
            {
                Master = new MenuPage(),
                Detail = new NavigationPage(new LoginPage())
            };
            Application.Current.MainPage = mainPage;
        }


    }
}