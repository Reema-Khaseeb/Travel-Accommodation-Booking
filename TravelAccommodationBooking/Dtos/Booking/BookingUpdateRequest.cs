using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.Booking
{
    public record BookingUpdateRequest(
        int BookingId,
        double TotalPrice,
        BookingStatus Status,
        DateTime UpdatedAt);
}
