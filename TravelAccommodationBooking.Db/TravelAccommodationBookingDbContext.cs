using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Configurations;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db
{
    public class TravelAccommodationBookingDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public TravelAccommodationBookingDbContext(
            DbContextOptions<TravelAccommodationBookingDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships and constraints
            modelBuilder.ApplyConfiguration(new UserConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
