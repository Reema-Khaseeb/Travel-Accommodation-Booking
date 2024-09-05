using AutoMapper;
using TravelAccommodationBooking.Dtos.Hotel;
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
    }
}
