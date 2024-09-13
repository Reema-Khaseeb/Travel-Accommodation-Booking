using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Services.Interfaces;

public interface IPaymentService
{
    Task<Payment> ProcessPaymentAsync(Payment payment);
}