using AutoMapper;
using TravelAccommodationBooking.Dtos.Booking;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.MappingProfiles;

public class BookingProfile : Profile
{
    public BookingProfile()
    {
        CreateMap<BookingRequest, Booking>().ReverseMap();
        CreateMap<BookingUpdateRequest, Booking>();
        CreateMap<Booking, BookingResponse>();
    }
}
