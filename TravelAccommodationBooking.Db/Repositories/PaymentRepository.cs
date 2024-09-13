using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;

namespace TravelAccommodationBooking.Db.Repositories;
public class PaymentRepository : IPaymentRepository
{
    private readonly TravelAccommodationBookingDbContext _context;

    public PaymentRepository(TravelAccommodationBookingDbContext context)
    {
        _context = context;
    }

    public async Task<Payment> CreatePaymentAsync(Payment payment)
    {
        _context.Payments.Add(payment);
        await _context.SaveChangesAsync();
        return payment;
    }
}
