using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Dtos.Booking
{
    public record BookingDetails(
        int BookingId,
        string HotelAddress,
        int RoomNumber,
        RoomType RoomType,
        string Description,
        DateTime CheckInDate,
        DateTime CheckOutDate,
        double TotalPrice);
}