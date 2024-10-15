using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Services;

public class PaymentService : IPaymentService
{
    private readonly IPaymentRepository _paymentRepository;
    private readonly IBookingService _bookingService;

    public PaymentService(IPaymentRepository paymentRepository, IBookingService bookingService)
    {
        _paymentRepository = paymentRepository;
        _bookingService = bookingService;
    }

    public async Task<Payment> ProcessPaymentAsync(Payment payment)
    {
        payment.PaymentDate = DateTime.UtcNow;
        double bookingPrice = await _bookingService.GetBookingPriceByBookingId(payment.BookingId);
        payment.Amount = (decimal)bookingPrice;
        
        bool paymentSuccess = true;

        if (paymentSuccess)
        {
            payment.Status = PaymentStatus.Success;
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
