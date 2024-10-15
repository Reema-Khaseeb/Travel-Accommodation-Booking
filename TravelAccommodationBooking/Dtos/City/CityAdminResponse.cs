namespace TravelAccommodationBooking.Dtos.City
{
    public record CityAdminResponse(
        string Name,
        string Country,
        string PostOffice,
        int NumberOfHotels,
        DateTime CreationDate,
        DateTime ModificationDate);
}
