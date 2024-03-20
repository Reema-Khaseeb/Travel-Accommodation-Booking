using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Common.Exceptions;
using Microsoft.Extensions.Logging;

namespace TravelAccommodationBooking.Services;
public class HotelLocationService : IHotelLocationService
{
    private readonly IHotelLocationRepository _hotellocationRepository;
    private readonly ILogger<HotelLocationService> _logger;

    public HotelLocationService(
        IHotelLocationRepository hotellocationRepository,
        ILogger<HotelLocationService> logger)
    {
        _hotellocationRepository = hotellocationRepository;
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<HotelLocation> GetLocationByIdAsync(int locationId)
    {
        var hotellocation = await _hotellocationRepository.GetLocationByIdAsync(locationId);

        if (hotellocation == null)
        {
            _logger.LogWarning($"Room with ID {locationId} not found.");
            throw new NotFoundException($"Room with ID {locationId} not found.");
        }

        _logger.LogInformation($"Room with ID {locationId} successfully retrieved.");
        return hotellocation;
    }
}
