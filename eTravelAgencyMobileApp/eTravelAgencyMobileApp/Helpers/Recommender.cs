using eTravelAgency.Core.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTravelAgencyMobileApp.Helpers
{
    public class Recommender
    {
        private readonly APIService _userService = new APIService("user");
        private readonly APIService _hOfferService = new APIService("hoteloffer");
        private readonly APIService _hotelService = new APIService("hotel");
        private readonly APIService _tCompanyService = new APIService("transportcompany");
        private readonly APIService _tOfferService = new APIService("transportoffer");
        private readonly APIService _ratingService = new APIService("rating");
        private readonly APIService _reservationService = new APIService("reservation");

        private int _id=0;
        private int _cityId=0;

        Dictionary<int, List<RatingDTO>> Ratings = new Dictionary<int, List<RatingDTO>>();


        public Recommender(int id,int cityId)
        {
            _id = id;
            _cityId = cityId;
        }

        private async void LoadHotels()
        {
            var hotels = (await _hotelService.Get<List<HotelDTO>>(null));
                hotels= hotels.Where(_ => _.Id != _id && _.CityId == _cityId).ToList();

            foreach (var hotel in hotels)
            {
                var ratings = await _ratingService.Get<List<RatingDTO>>(new RatingSearchRequest { HotelId = hotel.Id });
                List<RatingDTO> hotelRatings = new List<RatingDTO>();
                foreach (RatingDTO rating in ratings)
                {
                    hotelRatings.Add(rating);
                }
                Ratings.Add(hotel.Id, hotelRatings);
            }
                
        }

        public async Task<List<HotelDTO>> GetSimilarHotels()
        {
            List<RatingDTO> HotelRatings = await _ratingService.Get<List<RatingDTO>>(new RatingSearchRequest { HotelId = _id });

            List<HotelDTO> recommendedHotels = new List<HotelDTO>();
            List<RatingDTO> mutualRatings1 = new List<RatingDTO>();
            List<RatingDTO> mutualRatings2 = new List<RatingDTO>();

            var hotels = (await _hotelService.Get<List<HotelDTO>>(null));
            hotels = hotels.Where(_ => _.Id != _id && _.CityId == _cityId).ToList();

            foreach (var hotel in hotels)
            {
                var ratings = await _ratingService.Get<List<RatingDTO>>(new RatingSearchRequest { HotelId = hotel.Id });
                List<RatingDTO> hotelRatings = new List<RatingDTO>();
                foreach (RatingDTO rating in ratings)
                {
                    hotelRatings.Add(rating);
                }
                Ratings.Add(hotel.Id, hotelRatings);
            } 

             foreach (var item in Ratings)
            {
                foreach (var  rating in HotelRatings)
                {
                    if(item.Value.Any(_=>_.UserId == rating.UserId)){

                        mutualRatings1.Add(rating);
                        mutualRatings2.Add(item.Value.First(_ => _.UserId == rating.UserId));

                    }
                }
                double Similarity = GetSimilarity(mutualRatings1, mutualRatings2);
                    if (Similarity > 0.8)
                {
                    recommendedHotels.Add((await _hotelService.GetById<HotelDTO>(item.Key)));

                }
                mutualRatings1.Clear();
                mutualRatings2.Clear();
            }
            return recommendedHotels;
        }

        private double GetSimilarity(List<RatingDTO> mutualRatings1, List<RatingDTO> mutualRatings2)
        {
            if (mutualRatings1.Count != mutualRatings2.Count || mutualRatings1.Count== 0 || mutualRatings2.Count == 0) return 0;
            double avgRating1 = mutualRatings1.Average(_ => _.HotelRating);
            double avgRating2 = mutualRatings2.Average(_ => _.HotelRating);

            double nominator = 0;
            double denom=0,denominatorA = 0, denominatorB = 0;

            for (int i = 0; i < mutualRatings1.Count; i++)
            {
                nominator += (mutualRatings1[i].HotelRating * mutualRatings2[i].HotelRating);
                denominatorA += Math.Pow(mutualRatings1[i].HotelRating, 2);
                denominatorB += Math.Pow(mutualRatings2[i].HotelRating, 2);
            }

            denominatorA = Math.Sqrt(denominatorA);
            denominatorB = Math.Sqrt(denominatorB);

            denom = denominatorA * denominatorB;
            if (denom == 0) return 0;


            return nominator/denom;
        }


    }
}
