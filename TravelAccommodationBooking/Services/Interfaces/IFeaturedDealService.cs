using TravelAccommodationBooking.Dtos.FeaturedDeal;

namespace TravelAccommodationBooking.Services.Interfaces;
public interface IFeaturedDealService
{
    Task<IEnumerable<FeaturedDealDto>> GetActiveFeaturedDealsAsync();
}