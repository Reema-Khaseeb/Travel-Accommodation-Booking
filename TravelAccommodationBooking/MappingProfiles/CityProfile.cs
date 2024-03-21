using AutoMapper;
using TravelAccommodationBooking.Dtos.City;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.MappingProfiles;

public class CityProfile : Profile
{
    public CityProfile()
    {
        CreateMap<City, CityAdminRequest>().ReverseMap();
        //.ForMember(dest => dest.CityId, opt => opt.Ignore()); // Ignore the ID during mapping to prevent overwriting it from the DTO

        CreateMap<City, CityAdminResponse>()
        //    //.ForMember(dest => dest.NumberOfHotels, opt => opt.MapFrom(src => src.Hotels.Count()))
        //    .ForMember(dest => dest.NumberOfHotels, opt => opt.MapFrom(src => CalculateNumberOfHotels(src.Hotels)))
            .ReverseMap();
        CreateMap<City, CityAdminResponse>()
            .ForMember(dest => dest.NumberOfHotels, opt => opt.MapFrom(src => CalculateNumberOfHotels(src.Hotels)))
            .ReverseMap(); // Reverse mapping

        CreateMap<CityWithHotelsCountView, CityAdminResponse>();
        CreateMap<City, CityCreationResponse>().ReverseMap();



        CreateMap<City, CityAdminRequest>().ReverseMap();
        CreateMap<City, CityTrendingDestinationDto>().ReverseMap();
        CreateMap<City, CityUserResponse>().ReverseMap();
        //.ForMember(dest => dest.NumberOfHotels, opt => opt.MapFrom(src => src.Hotels != null ? src.Hotels.Count() : 0));
        //CreateMap<CityDto, City>()
        //.ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
        //.ForMember(dest => dest.Country, opt => opt.MapFrom(src => src.Country))
        //.ForMember(dest => dest.PostOffice, opt => opt.MapFrom(src => src.PostOffice));
    }

    private static int CalculateNumberOfHotels(IEnumerable<Hotel> hotels)
    {
        // Implement the logic to calculate the number of hotels.
        // This could be as simple as counting the items in the collection.
        return hotels?.Count() ?? 0;
    }
}
