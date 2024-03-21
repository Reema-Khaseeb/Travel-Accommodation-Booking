using TravelAccommodationBooking.Dtos.Hotel;

namespace TravelAccommodationBooking.Services.Interfaces
{
    public interface IHomeService
    {
        Task<IEnumerable<FeaturedDeal>> GetFeaturedDealsAsync();
    }
}