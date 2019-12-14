using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using eTravelAgency.Core.Models;
using eTravelAgency.Core.Requests;

namespace eTravelAgency.Model.Helpers
{
    public class MyMapper : Profile
    {
        public MyMapper()
        {
            CreateMap<Country, CountryDTO>().ReverseMap();
            CreateMap<CountryDTO, CountryInsertRequest>().ReverseMap();
            CreateMap<Country, CountryInsertRequest>().ReverseMap();

            CreateMap<City, CityDTO>().ReverseMap();
            CreateMap<CityDTO, CityInsertRequest>().ReverseMap();
            CreateMap<City, CityInsertRequest>().ReverseMap();

            CreateMap<Hotel, HotelDTO>().ReverseMap();
            CreateMap<HotelDTO, HotelInsertRequest>().ReverseMap();
            CreateMap<Hotel, HotelInsertRequest>().ReverseMap();

            CreateMap<HotelOffer, HotelOfferDTO>().ReverseMap();
            CreateMap<HotelOfferDTO, HotelInsertRequest>().ReverseMap();
            CreateMap<HotelOffer, HotelInsertRequest>().ReverseMap();

            //CreateMap<HotelRooms, HotelRoomsDTO>().ReverseMap();
            //CreateMap<HotelRoomsDTO, HotelRoomsInsertRequest>().ReverseMap();
            //CreateMap<HotelRooms, HotelRoomsInsertRequest>().ReverseMap();

            CreateMap<User, UserDTO>().ReverseMap();
            CreateMap<UserDTO, UserInsertRequest>().ReverseMap();
            CreateMap<User, UserInsertRequest>().ReverseMap();

            CreateMap<UserRolesDTO, UserRoles>().ReverseMap();

            CreateMap<TransportOffer, TransportOfferDTO>().ReverseMap();
            CreateMap<TransportOfferDTO, TransportOfferInsertRequest>().ReverseMap();
            CreateMap<TransportOfferInsertRequest, TransportOffer>().ReverseMap();

            CreateMap<CountryFavorites, CountryFavoritesDTO>().ReverseMap();
            CreateMap<CountryFavoritesDTO, CountryFavoritesInsertRequest>().ReverseMap();
            CreateMap<CountryFavorites, CountryFavoritesInsertRequest>().ReverseMap();

            CreateMap<Attraction, AttractionDTO>().ReverseMap();
            CreateMap<AttractionDTO, AttractionInsertRequest>().ReverseMap();
            CreateMap<Attraction, AttractionInsertRequest>().ReverseMap();

            CreateMap<TransportCompany, TransportCompanyDTO>().ReverseMap();
            CreateMap<TransportCompanyDTO, TransportCompanyInsertRequest>().ReverseMap();
            CreateMap<TransportCompany, TransportCompanyInsertRequest>().ReverseMap();

            CreateMap<TransportType, TransportTypeDTO>().ReverseMap();
            CreateMap<TransportTypeDTO, TransportTypeInsertRequest>().ReverseMap();
            CreateMap<TransportType, TransportTypeInsertRequest>().ReverseMap();

            CreateMap<Rating, RatingDTO>().ReverseMap();
            CreateMap<RatingDTO, RatingInsertRequest>().ReverseMap();
            CreateMap<Rating, RatingInsertRequest>().ReverseMap();

            CreateMap<Reservation, ReservationDTO>().ReverseMap();
            CreateMap<ReservationDTO, ReservationInsertRequest>().ReverseMap();
            CreateMap<Reservation, ReservationInsertRequest>().ReverseMap();

            CreateMap<Role, RoleDTO>().ReverseMap();
            CreateMap<RoleDTO, RoleInsertRequest>().ReverseMap();
            CreateMap<Role, RoleInsertRequest>().ReverseMap();

            //CreateMap<RoomType, RoomTypeDTO>().ReverseMap();
            //CreateMap<RoomTypeDTO, RoomTypeInsertRequest>().ReverseMap();
            //CreateMap<RoomType, RoomTypeInsertRequest>().ReverseMap();
        }
    }
}

