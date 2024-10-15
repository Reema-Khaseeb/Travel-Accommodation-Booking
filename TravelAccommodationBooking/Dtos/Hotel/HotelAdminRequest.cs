namespace TravelAccommodationBooking.Dtos.Hotel
{
    public record HotelAdminRequest
    (
        string Name,
        string Owner,
        string ThumbnailUrl,
        double Price,
        double DiscountRate,
        string Description,
        int CityId
    );
}
