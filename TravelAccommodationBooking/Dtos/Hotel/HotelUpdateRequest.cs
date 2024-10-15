namespace TravelAccommodationBooking.Dtos.Hotel
{
    public record HotelUpdateRequest
        (
        string? Name,
        string Address,
        string? Owner,
        int? CityId);
}
