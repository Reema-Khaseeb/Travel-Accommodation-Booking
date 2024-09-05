using AutoMapper;
using TravelAccommodationBooking.Dtos.Room;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.MappingProfiles;

public class RoomProfile : Profile
{
    public RoomProfile()
    {
        CreateMap<Room, RoomRequest>();
        CreateMap<Room, RoomResponse>().ReverseMap();
        CreateMap<Room, RoomUpdateRequest>().ReverseMap();
        CreateMap<Room, RoomAdminRequest>().ReverseMap();
        CreateMap<Room, RoomAdminResponse>().ReverseMap();
    }
}
