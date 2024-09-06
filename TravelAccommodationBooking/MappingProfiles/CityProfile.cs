using AutoMapper;
using TravelAccommodationBooking.Dtos.City;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.MappingProfiles;

public class CityProfile : Profile
{
    public CityProfile()
    {
        CreateMap<City, CityAdminRequest>().ReverseMap();
        CreateMap<City, CityAdminResponse>().ReverseMap();
        CreateMap<CityWithHotelsCountView, CityAdminResponse>();
        CreateMap<City, CityCreationResponse>().ReverseMap();
        CreateMap<City, CityUserResponse>().ReverseMap();
    }
}
