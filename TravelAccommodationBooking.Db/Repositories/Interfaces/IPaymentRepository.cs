using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db.Repositories.Interfaces;

    public interface IPaymentRepository
    {
        Task<Payment> CreatePaymentAsync(Payment payment);
    }
