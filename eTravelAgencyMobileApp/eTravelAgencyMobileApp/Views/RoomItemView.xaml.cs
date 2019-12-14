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
    public partial class RoomItemView : ContentView
    {
        private RoomItemViewModel _room = null;
        public RoomItemView()
        {
            InitializeComponent();
            _room = new RoomItemViewModel();
        }
        private void myStepper_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            _room._roomType.OrderedRooms = (int)e.NewValue;
        }
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

        }
    }
}