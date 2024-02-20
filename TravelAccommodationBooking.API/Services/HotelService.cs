using AutoMapper;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.API.Services.Interfaces;
using TravelAccommodationBooking.Db.Utilities.Exceptions;
using TravelAccommodationBooking.Db.Utilities.Enums;
using TravelAccommodationBooking.API.Models.Searching;
using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.API.Dtos.Hotel;
using TravelAccommodationBooking.API.Dtos.Responses;

namespace TravelAccommodationBooking.API.Services
{
    public class HotelService : IHotelService
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly ILogger<HotelService> _logger;
        private readonly IMapper _mapper;

        public HotelService(
            IHotelRepository hotelRepository,
            ILogger<HotelService> logger,
            IMapper mapper
            )
        {
            _hotelRepository = hotelRepository;
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _mapper = mapper;
        }

        public async Task<Hotel> CreateHotelAsync(Hotel hotel)
        {
            var newHotel = await _hotelRepository.CreateHotelAsync(hotel);
            _logger.LogInformation($"Hotel {newHotel.HotelId} created successfully.");
            return newHotel;
        }

        public async Task UpdateHotelAsync(int hotelId, HotelUpdateRequest hotelRequest)
        {
            var existedHotel = await _hotelRepository.GetHotelByIdAsync(hotelId);

            _mapper.Map(hotelRequest, existedHotel);
            existedHotel.ModificationDate = DateTime.UtcNow;
            await _hotelRepository.UpdateHotelAsync(existedHotel);
            _logger.LogInformation($"Hotel-{existedHotel.HotelId} updated successfully.");
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
    }
}
