using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Services;

public class PaymentService : IPaymentService
{
    private readonly IPaymentRepository _paymentRepository;
    private readonly IBookingService _bookingService;
    private readonly Random _random;

    public PaymentService(IPaymentRepository paymentRepository, IBookingService bookingService)
    {
        _paymentRepository = paymentRepository;
        _bookingService = bookingService;
        _random = new Random();
    }

    public async Task<Payment> ProcessPaymentAsync(Payment payment)
    {
        payment.PaymentDate = DateTime.UtcNow;

        // Simulate a random outcome of the payment process
        bool paymentSuccess = true; //_random.Next(0, 2) > 0;

        if (paymentSuccess)
        {
            payment.Status = PaymentStatus.Success;
            await _paymentRepository.CreatePaymentAsync(payment);
            await _bookingService.ConfirmBookingAsync(payment.BookingId);
        }
        else
        {
            payment.Status = PaymentStatus.Failed;
            await _bookingService.CancelReservationAsync(payment.BookingId);
        }

        return await _paymentRepository.CreatePaymentAsync(payment);
    }
}
