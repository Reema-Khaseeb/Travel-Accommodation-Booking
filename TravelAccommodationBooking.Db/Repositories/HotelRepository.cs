using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Common.Enums;

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

        public IQueryable<Hotel> GetHotelsQueryable()
        {
            return _context.Hotels;
        }

        public IQueryable<Hotel> FilterHotelsByCity(IQueryable<Hotel> query, int cityId)
        {
            return query.Where(h => h.CityId == cityId);
        }

        public IQueryable<Hotel> FilterHotelsByMinPrice(IQueryable<Hotel> query, double minPrice)
        {
            return query.Where(h => h.Price >= minPrice);
        }

        public IQueryable<Hotel> FilterHotelsByMaxPrice(IQueryable<Hotel> query, double maxPrice)
        {
            return query.Where(h => h.Price <= maxPrice);
        }

        public IQueryable<Hotel> FilterHotelsBySpecificStarRating(IQueryable<Hotel> query, StarRating starRating)
        {
            return query.Where(h => h.StarRating == starRating);
        }

        public IQueryable<Hotel> FilterHotelsByMinStarRating(IQueryable<Hotel> query, StarRating minRating)
        {
            return query.Where(h => h.StarRating >= minRating);
        }

        public IQueryable<Hotel> FilterHotelsByMaxStarRating(IQueryable<Hotel> query, StarRating maxRating)
        {
            return query.Where(h => h.StarRating <= maxRating);
        }

        public IQueryable<Hotel> FilterHotelsByRoomType(IQueryable<Hotel> query, RoomType roomType)
        {
            return query
                .Where(hotel => hotel.Rooms
                .Any(room => room.RoomType == roomType));
        }

        public IQueryable<Hotel> FilterHotelsByAdultsCapacity(IQueryable<Hotel> query, int numberOfAdults)
        {
            return query
                .Where(hotel => hotel.Rooms
                .Any(room => room.AdultsCapacity >= numberOfAdults));
        }

        public IQueryable<Hotel> FilterHotelsByChildrenCapacity(IQueryable<Hotel> query, int numberOfChildren)
        {
            return query
                .Where(hotel => hotel.Rooms
                .Any(room => room.ChildrenCapacity >= numberOfChildren));
        }
    }
}
