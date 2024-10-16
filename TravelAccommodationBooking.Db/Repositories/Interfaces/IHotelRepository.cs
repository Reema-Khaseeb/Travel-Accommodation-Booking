﻿using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Db.Repositories.Interfaces
{
    public interface IHotelRepository
    {
        Task<Hotel> CreateHotelAsync(Hotel hotel);
        Task UpdateHotelAsync(Hotel hotel);
        Task DeleteHotelAsync(Hotel hotel);
        Task<Hotel> GetHotelByIdAsync(int hotelId);
        Task<IEnumerable<Hotel>> GetHotelsAsync();
        IQueryable<Hotel> GetHotelsQueryable();
        IQueryable<Hotel> FilterHotelsByMinStarRating(IQueryable<Hotel> query, StarRating minRating);
        IQueryable<Hotel> FilterHotelsByAdultsCapacity(IQueryable<Hotel> query, int numberOfAdults);
        IQueryable<Hotel> FilterHotelsByChildrenCapacity(IQueryable<Hotel> query, int numberOfChildren);
        IQueryable<Hotel> FilterHotelsByCity(IQueryable<Hotel> query, int cityId);
        IQueryable<Hotel> FilterHotelsByMaxPrice(IQueryable<Hotel> query, double maxPrice);
        IQueryable<Hotel> FilterHotelsByMaxStarRating(IQueryable<Hotel> query, StarRating maxRating);
        IQueryable<Hotel> FilterHotelsByMinPrice(IQueryable<Hotel> query, double minPrice);
        IQueryable<Hotel> FilterHotelsByRoomType(IQueryable<Hotel> query, RoomType roomType);
        IQueryable<Hotel> FilterHotelsBySpecificStarRating(IQueryable<Hotel> query, StarRating starRating);
    }
}