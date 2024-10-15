namespace TravelAccommodationBooking.Dtos.City
{
    public record CityUserResponse(
       int CityId,
        string Name,
        string Country,
        string PostOffice,
        int NumberOfHotels);
}
