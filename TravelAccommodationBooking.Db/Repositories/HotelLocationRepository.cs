using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;

namespace TravelAccommodationBooking.Db.Repositories
{
    public class HotelLocationRepository : IHotelLocationRepository
    {
        private readonly TravelAccommodationBookingDbContext _dbContext;

        public HotelLocationRepository(TravelAccommodationBookingDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<HotelLocation> GetLocationByIdAsync(int locationId)
        {
            return await _dbContext.Locations.FindAsync(locationId);
        }
    }
}
