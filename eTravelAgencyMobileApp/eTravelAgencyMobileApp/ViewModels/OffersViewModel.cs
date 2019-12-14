using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using System.Drawing;
using System.Linq;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class OffersViewModel: BaseViewModel
    {
       
        public TransportOfferViewModel transportsOffer { get; set; }
        public HotelOfferViewModel hotelOffers { get; set; } 
        
        public ICommand InitCommand { get; set; }

        public OffersViewModel()
        {
            transportsOffer = new TransportOfferViewModel();
            hotelOffers = new HotelOfferViewModel();
            InitCommand = new Command(async () => await Init());
        }
        public OffersViewModel(int? id= null)
        {
            
            transportsOffer = new TransportOfferViewModel(id);
            hotelOffers = new HotelOfferViewModel(id);
            InitCommand = new Command(async () => await Init());

        }


        public async Task Init()
        {
            try
            {
                await transportsOffer.Init();
                await hotelOffers.Init();
            }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
