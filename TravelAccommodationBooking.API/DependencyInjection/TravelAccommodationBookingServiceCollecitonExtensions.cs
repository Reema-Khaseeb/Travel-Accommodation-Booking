using TravelAccommodationBooking.Services;
using TravelAccommodationBooking.Services.Interfaces;
using TravelAccommodationBooking.Db;

namespace TravelAccommodationBooking.API.DependencyInjection
{
    public static class TravelAccommodationBookingsServiceCollecitonExtensions
    {
        public static IServiceCollection AddTravelAccommodationBookings(this IServiceCollection services)
        {
            services.AddScoped<TravelAccommodationBookingDbContext>();
            services.AddScoped<IAuthenticationService, AuthenticationService>();
            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IPasswordHasher, PasswordHasher>();

            return services;
        }
    }
}
