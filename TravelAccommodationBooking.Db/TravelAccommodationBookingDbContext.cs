using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Configurations;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db
{
    public class TravelAccommodationBookingDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelLocation> Locations { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        public IEnumerable<Review> Reviews { get; set; }

        public TravelAccommodationBookingDbContext(
            DbContextOptions<TravelAccommodationBookingDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships and constraints
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new HotelConfiguration());
            modelBuilder.ApplyConfiguration(new HotelImageConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
