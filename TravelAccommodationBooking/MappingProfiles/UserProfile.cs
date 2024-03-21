using AutoMapper;
using TravelAccommodationBooking.Dtos.User;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.MappingProfiles;

public class UserProfile : Profile
{
    public UserProfile()
    {
        CreateMap<UserResponse, User>().ReverseMap();
        CreateMap<UserRequest, User>().ReverseMap();
    }
}
