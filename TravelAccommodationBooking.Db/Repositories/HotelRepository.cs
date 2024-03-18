using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;

namespace TravelAccommodationBooking.Db.Repositories
{
    public class HotelRepository : IHotelRepository
    {
        private readonly TravelAccommodationBookingDbContext _context;

        public HotelRepository(TravelAccommodationBookingDbContext context)
        {
            _context = context;
        }

        public async Task<Hotel> CreateHotelAsync(Hotel hotel)
        {
            await _context.Hotels.AddAsync(hotel);
            await _context.SaveChangesAsync();
            return hotel;
        }

        public async Task UpdateHotelAsync(Hotel hotel)
        {
            _context.Hotels.Update(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteHotelAsync(Hotel hotel)
        {
            _context.Hotels.Remove(hotel);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Hotel>> GetHotelsAsync()
        {
            return await _context.Hotels.ToListAsync();
        }

        public async Task<Hotel> GetHotelByIdAsync(int hotelId)
        {
            return await _context.Hotels.FindAsync(hotelId);
        }
    }
}
