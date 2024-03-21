using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Common.Enums;
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

        public IQueryable<Hotel> GetHotelsQueryable()
        {
            return _context.Hotels;
        }

        public async Task<Hotel> GetHotelByNameAsync(string hotelName)
        {
            return await _context.Hotels
                .FirstOrDefaultAsync(hotel => hotel.Name == hotelName);
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

        public async Task<IEnumerable<Hotel>> GetFeaturedDealsHotelsAsync()
        {
            return await _context.Hotels
                                   .Where(hotel => hotel.DiscountRate > 0)
                                   .OrderByDescending(hotel => hotel.DiscountRate)
                                   .Take(5)
                                   .ToListAsync();
        }

        public async Task<IEnumerable<HotelImage>> GetHotelImagesAsync(int hotelId)
        {
            return await _context.HotelImages
                .Where(img => img.HotelId == hotelId)
                .ToListAsync();
        }

        public async Task<HotelLocation> GetHotelLocationAsync(int hotelId)
        {
            return await _context.Hotels
                .Where(h => h.HotelId == hotelId)
                .Select(h => h.Location)
                .FirstOrDefaultAsync();
        }

        /*

        private IQueryable<Hotel> ApplyDateFilter(IQueryable<Hotel> query, DateTime? checkIn, DateTime? checkOut)
        {
            // Note: This logic assumes the existence of a Bookings collection in the Hotel entity
            return (checkIn.HasValue && checkOut.HasValue) ?
                query.Where(h => h.Rooms.Any(r => !r.Bookings.Any(b => b.CheckInDate < checkOut && b.CheckOutDate > checkIn))) :
                query;
        }
        */

    }
}
