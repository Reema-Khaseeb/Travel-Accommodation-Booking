﻿using AutoMapper;
using TravelAccommodationBooking.API.Dtos.City;
using TravelAccommodationBooking.API.Services.Interfaces;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Repositories.Interfaces;
using TravelAccommodationBooking.Db.Utilities.Exceptions;

namespace TravelAccommodationBooking.API.Services
{
    public class CityService : ICityService
    {
        private readonly IBookingRepository _bookingRepository;
        private readonly ICityRepository _cityRepository;
        private readonly ILogger<CityService> _logger;
        private readonly IMapper _mapper;

        public CityService(
            ICityRepository cityRepository,
            ILogger<CityService> logger,
            IMapper mapper)
        {
            _cityRepository = cityRepository;
            _logger = logger;
            _mapper = mapper;
        }

        public async Task<City> CreateCityAsync(City city)
        {
            var newCity = await _cityRepository.CreateCityAsync(city);
            _logger.LogInformation($"City {city.Name} created successfully.");
            return newCity;
        }

        public async Task UpdateCityAsync(int cityId, CityUpdateRequest cityRequest)
        {
            var existedCity = await _cityRepository.GetCityByIdAsync(cityId);

            _mapper.Map(cityRequest, existedCity);
            existedCity.ModificationDate = DateTime.UtcNow;
            await _cityRepository.UpdateCityAsync(existedCity);
            _logger.LogInformation($"City-{existedCity.CityId} updated successfully.");
        }

        public async Task DeleteCityAsync(int cityId)
        {
            var city = await _cityRepository.GetCityByIdAsync(cityId);
            await _cityRepository.DeleteCityAsync(city);
            _logger.LogInformation($"City with ID: {cityId} has been successfully deleted.");
        }

        public async Task<City> GetCityByIdAsync(int cityId)
        {
            var city = await _cityRepository.GetCityByIdAsync(cityId);

            if (city is null)
            {
                _logger.LogWarning($"City with ID {cityId} not found.");
                throw new NotFoundException($"City with ID {cityId} not found.");
            }
            _logger.LogInformation($"City with ID {cityId} successfully retrieved.");
            return city;
        }

        public async Task<IEnumerable<City>> GetCitiesAsync()
        {
            var cities = await _cityRepository.GetCitiesAsync();
            _logger.LogInformation("All cities successfully retrieved.");
            return cities;
        }
    }
}