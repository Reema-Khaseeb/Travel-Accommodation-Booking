using AutoMapper;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Dtos.Payment;

namespace TravelAccommodationBooking.MappingProfiles;

public class PaymentProfile : Profile
{
    public PaymentProfile()
    {
        CreateMap<Payment, PaymentDto>().ReverseMap();
    }
}
