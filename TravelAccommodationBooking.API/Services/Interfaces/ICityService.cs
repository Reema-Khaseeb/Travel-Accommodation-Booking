using TravelAccommodationBooking.API.Dtos.City;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.API.Services.Interfaces
{
    public interface ICityService
    {
        Task<City> CreateCityAsync(City city);
        Task UpdateCityAsync(int cityId, CityUpdateRequest cityRequest);
        Task DeleteCityAsync(int cityId);
        Task<IEnumerable<City>> GetCitiesAsync();
        Task<City> GetCityByIdAsync(int cityId);
    }
}