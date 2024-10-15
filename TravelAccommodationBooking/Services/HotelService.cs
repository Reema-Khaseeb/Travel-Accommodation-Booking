using AutoMapper;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Common.Exceptions;
using TravelAccommodationBooking.Common.Enums;
using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Dtos.Hotel;
using TravelAccommodationBooking.Dtos.Responses;
using TravelAccommodationBooking.Dtos.Searching;
using Microsoft.Extensions.Logging;

namespace TravelAccommodationBooking.Services;
public class HotelService : IHotelService
{
    private readonly IHotelRepository _hotelRepository;
    private readonly ICityService _cityService;
    private readonly ILogger<HotelService> _logger;
    private readonly IMapper _mapper;

    public HotelService(
        IHotelRepository hotelRepository,
        ICityService cityService,
        ILogger<HotelService> logger,
        IMapper mapper
        )
    {
        _hotelRepository = hotelRepository;
        _cityService = cityService;
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        _mapper = mapper;
    }

    public async Task<Hotel> CreateHotelAsync(Hotel hotel)
    {
        var newHotel = await _hotelRepository.CreateHotelAsync(hotel);
        _logger.LogInformation($"Hotel {newHotel.HotelId} created successfully.");
        return newHotel;
    }

    public async Task UpdateHotelAsync(int hotelId, HotelUpdateRequest hotelUpdateRequest)
    {
        var existedHotel = await _hotelRepository.GetHotelByIdAsync(hotelId);
        _mapper.Map(hotelUpdateRequest, existedHotel);

        // Validate and update foreign keys
        await UpdateCityForHotelAsync(existedHotel, hotelUpdateRequest.CityId);

        existedHotel.ModificationDate = DateTime.UtcNow;

        try
        {
            await _hotelRepository.UpdateHotelAsync(existedHotel);
            _logger.LogInformation($"Hotel-{existedHotel.HotelId} updated successfully.");
        }
        catch (Exception ex)
        {
            throw new DatabaseUpdateException("An error occurred while updating the hotel.", ex);
        }
    }

    public async Task DeleteHotelAsync(int hotelId)
    {
        var hotel = await _hotelRepository.GetHotelByIdAsync(hotelId);
        await _hotelRepository.DeleteHotelAsync(hotel);
        _logger.LogInformation($"Hotel with ID: {hotelId} has been successfully deleted.");
    }

    public async Task<Hotel> GetHotelByIdAsync(int hotelId)
    {
        var hotel = await _hotelRepository.GetHotelByIdAsync(hotelId);

        if (hotel == null)
        {
            _logger.LogWarning($"Hotel with ID {hotelId} not found.");
            throw new NotFoundException($"A hotel with the ID {hotelId} was not found.");
        }
        _logger.LogInformation($"Hotel with ID {hotelId} successfully retrieved.");
        return hotel;
    }

    public async Task<IEnumerable<Hotel>> GetHotelsAsync()
    {
        var hotels = await _hotelRepository.GetHotelsAsync();
        _logger.LogInformation("All Hotels successfully retrieved.");
        return hotels;
    }

    private async Task UpdateCityForHotelAsync(Hotel existingHotel, int? cityId)
    {
        if (cityId.HasValue)
        {
            try
            {
                var existingCity = await _cityService.GetCityByIdAsync(cityId.Value);
                existingHotel.City = existingCity;
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error while validating and setting City for the updated hotel.");
                throw;
            }
        }
    }

    public async Task<PaginatedResponse<HotelSearchResponse>> SearchPaginatedAsync(SearchCriteria criteria)
    {
        var query = _hotelRepository.GetHotelsQueryable();

        //// Apply filters based on the provided criteria
        query = FilterHotelsByCity(query, criteria.CityId);
        query = FilterHotelsByMinPrice(query, criteria.MinPrice);
        query = FilterHotelsByMaxPrice(query, criteria.MaxPrice);
        query = FilterHotelsBySpecificStarRating(query, criteria.StarRating);
        query = FilterHotelsByMinStarRating(query, criteria.MinStarRating);
        query = FilterHotelsByMaxStarRating(query, criteria.MaxStarRating);
        query = FilterHotelsByRoomType(query, criteria.RoomType);
        query = FilterHotelsByAdultsCapacity(query, criteria.NumberOfAdults);
        query = FilterHotelsByChildrenCapacity(query, criteria.NumberOfChildren);

        // get search query result paginated
        var paginatedHotels = await query
            .Skip((criteria.PageNumber - 1) * criteria.PageSize)
            .Take(criteria.PageSize)
            .ToListAsync();
        var totalCount = query.Count();  // await query.CountAsync();
        var totalPages = (int)Math.Ceiling(totalCount / (double)criteria.PageSize);
        var PaginatedhotelsResponses = _mapper.Map<IEnumerable<HotelSearchResponse>>(paginatedHotels);

        return new PaginatedResponse<HotelSearchResponse>
        {
            Items = PaginatedhotelsResponses,
            CurrentPage = criteria.PageNumber,
            TotalPages = totalPages,
            PageSize = criteria.PageSize,
            TotalCount = totalCount
        };
    }

    public IQueryable<Hotel> FilterHotelsByCity(IQueryable<Hotel> query, int? cityId)
    {
        return cityId.HasValue
            ? _hotelRepository.FilterHotelsByCity(query, cityId.Value)
            : query;
    }

    public IQueryable<Hotel> FilterHotelsByMinPrice(IQueryable<Hotel> query, double? minPrice)
    {
        return minPrice.HasValue
            ? _hotelRepository.FilterHotelsByMinPrice(query, minPrice.Value)
            : query;
    }

    public IQueryable<Hotel> FilterHotelsByMaxPrice(IQueryable<Hotel> query, double? maxPrice)
    {
        return maxPrice.HasValue
            ? _hotelRepository.FilterHotelsByMaxPrice(query, maxPrice.Value)
            : query;
    }

    public IQueryable<Hotel> FilterHotelsBySpecificStarRating(IQueryable<Hotel> query, StarRating? specificStarRating)
    {
        return specificStarRating.HasValue
            ? _hotelRepository.FilterHotelsBySpecificStarRating(query, specificStarRating.Value)
            : query;
    }

    public IQueryable<Hotel> FilterHotelsByMinStarRating(IQueryable<Hotel> query, StarRating? minStarRating)
    {
        return minStarRating.HasValue
            ? _hotelRepository.FilterHotelsByMinStarRating(query, minStarRating.Value)
            : query;
    }

    public IQueryable<Hotel> FilterHotelsByMaxStarRating(IQueryable<Hotel> query, StarRating? maxStarRating)
    {
        return maxStarRating.HasValue
            ? _hotelRepository.FilterHotelsByMaxStarRating(query, maxStarRating.Value)
            : query;
    }

    public IQueryable<Hotel> FilterHotelsByRoomType(IQueryable<Hotel> query, RoomType? roomType)
    {
        return roomType.HasValue
            ? _hotelRepository.FilterHotelsByRoomType(query, roomType.Value)
            : query;
    }

    public IQueryable<Hotel> FilterHotelsByAdultsCapacity(IQueryable<Hotel> query, int? numberOfAdults)
    {
        return numberOfAdults.HasValue
            ? _hotelRepository.FilterHotelsByAdultsCapacity(query, numberOfAdults.Value)
            : query;
    }

    public IQueryable<Hotel> FilterHotelsByChildrenCapacity(IQueryable<Hotel> query, int? numberOfChildren)
    {
        return numberOfChildren.HasValue
            ? _hotelRepository.FilterHotelsByChildrenCapacity(query, numberOfChildren.Value)
            : query;
    }
}
