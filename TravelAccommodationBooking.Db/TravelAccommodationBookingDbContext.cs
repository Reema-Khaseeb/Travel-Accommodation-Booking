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
        public DbSet<HotelImage> HotelImages { get; set; }
        public IEnumerable<Review> Reviews { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<CityWithHotelsCountView> CitiesWithHotelsCountView { get; set; }
        public DbSet<FeaturedDeal> FeaturedDeals { get; set; }

        public TravelAccommodationBookingDbContext(
            DbContextOptions<TravelAccommodationBookingDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure relationships and constraints
            modelBuilder.ApplyConfiguration(new UserConfiguration());
            modelBuilder.ApplyConfiguration(new CityConfiguration());
            modelBuilder.ApplyConfiguration(new HotelConfiguration());
            modelBuilder.ApplyConfiguration(new HotelImageConfiguration());
            modelBuilder.ApplyConfiguration(new ReviewConfiguration());
            modelBuilder.ApplyConfiguration(new RoomConfiguration());
            modelBuilder.ApplyConfiguration(new BookingConfiguration());
            modelBuilder.ApplyConfiguration(new PaymentConfiguration());
            modelBuilder.ApplyConfiguration(new FeaturedDealConfiguration());
            modelBuilder.Entity<CityWithHotelsCountView>().HasNoKey().ToView(nameof(CityWithHotelsCountView));

            base.OnModelCreating(modelBuilder);
        }
    }
}
