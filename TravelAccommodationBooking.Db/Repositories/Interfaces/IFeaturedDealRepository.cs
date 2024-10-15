using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db.Repositories.Interfaces;

public interface IFeaturedDealRepository
{
    Task<IEnumerable<FeaturedDeal>> GetActiveFeaturedDealsAsync(int count = 5);
}