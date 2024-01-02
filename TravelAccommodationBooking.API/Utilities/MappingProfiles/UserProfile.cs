using AutoMapper;
using TravelAccommodationBooking.API.Models.User;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.API.Utilities.MappingProfiles
{
    public class UserProfile : Profile
    {
        public UserProfile()
        {
            CreateMap<UserResponse, User>().ReverseMap();
            CreateMap<UserRequest, User>().ReverseMap();
        }
    }
}
