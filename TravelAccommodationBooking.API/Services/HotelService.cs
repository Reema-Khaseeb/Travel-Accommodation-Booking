﻿using AutoMapper;
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
        private readonly ICityService _cityService;
        private readonly IHotelLocationService _hotelLocationService;
        private readonly ILogger<HotelService> _logger;
        private readonly IMapper _mapper;

        public HotelService(
            IHotelRepository hotelRepository,
            ICityService cityService,
            IHotelLocationService hotelLocationService,
            ILogger<HotelService> logger,
            IMapper mapper
            )
        {
            _hotelRepository = hotelRepository;
            _cityService = cityService;
            _hotelLocationService = hotelLocationService;
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
            await UpdateLocationForHotelAsync(existedHotel, hotelUpdateRequest.LocationId);

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

        private async Task UpdateLocationForHotelAsync(Hotel existingHotel, int? locationId)
        {
            if (locationId.HasValue)
            {
                try
                {
                    var existingLocation = await _hotelLocationService.GetLocationByIdAsync(locationId.Value);
                    existingHotel.Location = existingLocation;
                }
                catch (Exception ex)
                {
                    _logger.LogError(ex, "Error while validating and setting Location for the updated hotel.");
                    throw;
                }
            }
        }
    }
}
