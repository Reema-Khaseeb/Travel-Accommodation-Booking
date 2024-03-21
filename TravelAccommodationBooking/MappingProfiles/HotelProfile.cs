﻿using AutoMapper;
using TravelAccommodationBooking.Dtos.Hotel;
using TravelAccommodationBooking.API.Models.Searching;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.MappingProfiles;

public class HotelProfile : Profile
{
    public HotelProfile()
    {
        CreateMap<Hotel, HotelDto>().ReverseMap();
        CreateMap<Hotel, HotelUpdateRequest>().ReverseMap();
        CreateMap<Hotel, HotelAdminRequest>().ReverseMap();
        CreateMap<Hotel, HotelAdminResponse>().ReverseMap();
        CreateMap<Hotel, HotelResponse>();


        CreateMap<Hotel, HotelSearchResponse>().ReverseMap();
        CreateMap<Hotel, FeaturedDeal>()
            .ForMember(dest => dest.DiscountedPrice, opt => opt.MapFrom(src => src
                .Price * (1 - src.DiscountRate / 100)));



        CreateMap<SearchCriteriaRequest, SearchCriteria>().ReverseMap();
        CreateMap<SearchCriteriaRequest, SearchCriteria>();
    }
}