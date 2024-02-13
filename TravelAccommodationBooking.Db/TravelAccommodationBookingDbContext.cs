using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Configurations;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db
{
    public class TravelAccommodationBookingDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<HotelLocation> Locations { get; set; }
        public DbSet<HotelImage> HotelImages { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }

        public TravelAccommodationBookingDbContext(
            DbContextOptions<TravelAccommodationBookingDbContext> options)
            : base(options)
        {
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(
        //        @"Server=localhost\SQLEXPRESS;Database=TravelAccommodationBookingCore;Trusted_Connection=True;Encrypt=False"
        //        );
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships and constraints
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new HotelConfiguration());
            modelBuilder.ApplyConfiguration(new HotelImageConfiguration());
            modelBuilder.ApplyConfiguration(new LocationConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
