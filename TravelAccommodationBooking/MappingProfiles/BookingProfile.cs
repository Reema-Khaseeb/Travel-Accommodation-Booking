using AutoMapper;
using TravelAccommodationBooking.Dtos.Booking;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.MappingProfiles;

public class BookingProfile : Profile
{
    public BookingProfile()
    {
        CreateMap<BookingRequest, Booking>().ReverseMap();
        CreateMap<Booking, BookingResponse>();
        CreateMap<Booking, BookingDetails>();
    }
}
