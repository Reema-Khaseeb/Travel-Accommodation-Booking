using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db.Repositories.Interfaces
{
    public interface ICityRepository
    {
        Task<City> CreateCityAsync(City city);
        Task UpdateCityAsync(City city);
        Task DeleteCityAsync(City city);
        Task<City> GetCityByIdAsync(int cityId);
        Task<IEnumerable<City>> GetCitiesAsync();
        Task<IEnumerable<CityWithHotelsCountView>> GetCitiesWithHotelsCountViewAsync();
        Task<CityWithHotelsCountView> GetCityByIdWithHotelsCountViewAsync(int cityId);
    }
}