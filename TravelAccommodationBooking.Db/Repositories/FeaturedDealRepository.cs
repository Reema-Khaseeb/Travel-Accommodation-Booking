using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;

namespace TravelAccommodationBooking.Db.Repositories;

public class FeaturedDealRepository : IFeaturedDealRepository
{
    private readonly TravelAccommodationBookingDbContext _context;

    public FeaturedDealRepository(TravelAccommodationBookingDbContext context)
    {
        _context = context;
    }

    public async Task<IEnumerable<FeaturedDeal>> GetActiveFeaturedDealsAsync(int count = 5)
    {
        return await _context.FeaturedDeals
            .Include(fd => fd.Hotel)
            .Where(fd => fd.StartDate <= DateTime.UtcNow && fd.EndDate >= DateTime.UtcNow)
            .Take(count)
            .ToListAsync();
    }
}
