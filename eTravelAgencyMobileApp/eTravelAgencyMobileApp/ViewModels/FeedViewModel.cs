using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace eTravelAgencyMobileApp.ViewModels
{
    public class FeedViewModel :BaseViewModel
    {
        private readonly APIService _countryService = new APIService("country");
        private readonly APIService _hotelService = new APIService("hotel");
        private readonly APIService _tCompanyService = new APIService("transportcompany");
        private readonly APIService _reservationService = new APIService("reservation");

        public ObservableCollection<CountryDTO> Countries { get; set; } = new ObservableCollection<CountryDTO>();
        public ObservableCollection<HotelDTO> Hotels { get; set; } = new ObservableCollection<HotelDTO>();
        public ObservableCollection<TransportCompanyDTO> Transports { get; set; } = new ObservableCollection<TransportCompanyDTO>();


        private int _allTimeVisits;

        public int AllTimeVisits { get { return _allTimeVisits; } set { SetProperty(ref _allTimeVisits, value); } }

        private Dictionary<int,int> bestOffer(ref Dictionary<int,int>source,Dictionary<int,int>destination)
        {
            int cnt = 0;
            foreach (var pair in source)
            {
                if (cnt == 5) break;
                KeyValuePair<int, int> temp = pair;
                foreach (var otherpair in source)
                {
                    if (pair.Key != otherpair.Key && otherpair.Value > temp.Value)
                    {
                        temp = otherpair;
                    }
                }
                destination.Add(temp.Key, temp.Value);
                source.Remove(temp.Key);
                cnt++;
            }
            source.Clear();
            return destination;
        }

        public async Task Init()
        {
            var countries = await _countryService.Get<List<CountryDTO>>(null);

            foreach (var country in countries)
            {
                Countries.Add(country);
            }

            
            var hotelData = (await _hotelService.Get<List<HotelDTO>>(null)).OrderByDescending(_=>_.TotalVisits).Take(5);
            var tCompanyData = (await _tCompanyService.Get<List<TransportCompanyDTO>>(null)).OrderByDescending(_ => _.TotalReservations).Take(5);

            foreach (var hotel in hotelData)
            {
                Hotels.Add(hotel);   
            }
            foreach (var tcompany in tCompanyData)
            {
                Transports.Add(tcompany);
            }

            int visits = 0;
            var reservations = await _reservationService.Get<List<ReservationDTO>>(null);
            foreach (var item in reservations)
            {
                visits += item.NumberOfPersons;
            }
            AllTimeVisits = visits;

            //Dictionary<int, int> topOffers = new Dictionary<int, int>();
            //Dictionary<int, int> bestHotels = new Dictionary<int, int>();
            //Dictionary<int, int> bestTransports = new Dictionary<int, int>();

            //#region hotels
            //foreach (var hOffer in hOffers)
            //{
            //    var reservations = (await _reservationService.Get<List<ReservationDTO>>(new ReservationSearchRequest { HotelOfferId = hOffer.Id})).Count;

            //    if (topOffers.ContainsKey(hOffer.HotelId))
            //    {
            //        topOffers[hOffer.HotelId] += reservations;
            //    }
            //    else
            //    {
            //        topOffers.Add(hOffer.HotelId, reservations);
            //    }
            //}
            //var offers = bestOffer(ref topOffers, bestHotels);

            //foreach (var hotel in offers)
            //{
            //    var bestHotel = await _hotelService.GetById<HotelDTO>(hotel.Key);
            //    Hotels.Add(bestHotel);
            //}
            //#endregion



            //#region transports

            //foreach (var tOffer in tOffers)
            //{
            //    var reservations = (await _reservationService.Get<List<ReservationDTO>>(new ReservationSearchRequest {TransportOfferId = tOffer.Id})).Count;

            //    if (topOffers.ContainsKey(tOffer.TransportCompanyId))
            //    {
            //        topOffers[tOffer.TransportCompanyId] += reservations;
            //    }
            //    else
            //    {
            //        topOffers.Add(tOffer.TransportCompanyId, reservations);
            //    }
            //}


            //offers = bestOffer(ref topOffers, bestTransports);
            
            //foreach (var transport in offers)
            //{
            //    var bestTransport = await _tCompanyService.GetById<TransportCompanyDTO>(transport.Key);
            //    Transports.Add(bestTransport);
            //}
            //#endregion
        }

    }
}
