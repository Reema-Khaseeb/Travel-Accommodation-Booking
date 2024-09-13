using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.Payment;
public record PaymentDto(
    bool IsProcessed,
    PaymentStatus Status,
    int BookingId);
