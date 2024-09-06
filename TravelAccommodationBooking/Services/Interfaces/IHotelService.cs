using TravelAccommodationBooking.Dtos.Hotel;
using TravelAccommodationBooking.Dtos.Responses;
using TravelAccommodationBooking.Dtos.Searching;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Common.Enums;

namespace TravelAccommodationBooking.Services.Interfaces;
public interface IHotelService
{
    Task<Hotel> CreateHotelAsync(Hotel hotel);
    Task UpdateHotelAsync(int hotelId, HotelUpdateRequest hotelRequest);
    Task DeleteHotelAsync(int hotelId);
    Task<Hotel> GetHotelByIdAsync(int hotelId);
    Task<IEnumerable<Hotel>> GetHotelsAsync();
    Task<PaginatedResponse<HotelSearchResponse>> SearchPaginatedAsync(SearchCriteria criteria);
    IQueryable<Hotel> FilterHotelsByAdultsCapacity(IQueryable<Hotel> query, int? numberOfAdults);
    IQueryable<Hotel> FilterHotelsByChildrenCapacity(IQueryable<Hotel> query, int? numberOfChildren);
    IQueryable<Hotel> FilterHotelsByCity(IQueryable<Hotel> query, int? cityId);
    IQueryable<Hotel> FilterHotelsByMaxPrice(IQueryable<Hotel> query, double? maxPrice);
    IQueryable<Hotel> FilterHotelsByMaxStarRating(IQueryable<Hotel> query, StarRating? maxStarRating);
    IQueryable<Hotel> FilterHotelsByMinPrice(IQueryable<Hotel> query, double? minPrice);
    IQueryable<Hotel> FilterHotelsByMinStarRating(IQueryable<Hotel> query, StarRating? minStarRating);
    IQueryable<Hotel> FilterHotelsByRoomType(IQueryable<Hotel> query, RoomType? roomType);
    IQueryable<Hotel> FilterHotelsBySpecificStarRating(IQueryable<Hotel> query, StarRating? specificStarRating);
}