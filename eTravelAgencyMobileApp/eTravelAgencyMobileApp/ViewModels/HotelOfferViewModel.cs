using eTravelAgency.Core.Requests;
using eTravelAgencyMobileApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class HotelOfferViewModel:BaseViewModel
    {
        private readonly APIService _hOfferService = new APIService("hoteloffer");
        private readonly APIService _hotelService = new APIService("hotel");
        private int? _id;

        public ObservableCollection<HotelOfferModel> hotels { get; set; } = new ObservableCollection<HotelOfferModel>();

        public HotelOfferViewModel(int? id =null)
        {
            _id = id;
        }

        public async Task Init()
        {
            List<HotelDTO> hotelData = null;
            List<HotelOfferDTO> hOfferData = null;


            if (_id.HasValue)
            {
                hotelData = await _hotelService.Get<List<HotelDTO>>(new HotelSearchRequest { CityId = _id.Value});
                foreach (var item in hotelData)
                {
                    var hotelOffer = (await _hOfferService.Get<List<HotelOfferDTO>>(new HotelOfferSearchRequest { HotelId = item.Id,IsActive=true}));
                    foreach (var hOffer in hotelOffer)
                    {
                        hotels.Add(new HotelOfferModel
                        {
                            Name = item.HotelName,
                            hOffer = hOffer
                        });
                    }
                }

            }
            else
            {
                hotelData = await _hotelService.Get<List<HotelDTO>>(null);
                hOfferData = await _hOfferService.Get<List<HotelOfferDTO>>(null);
            foreach (var item in hOfferData)
            {
                var hotel = hotelData.FirstOrDefault(_ => _.Id == item.HotelId);
                hotels.Add(new HotelOfferModel
                {
                    hOffer = item,
                    Name = hotel.HotelName
                });
            }
            }
        }

    }
}
