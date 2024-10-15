using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Utilities;

namespace TravelAccommodationBooking.Db.Configurations
{
    public class HotelConfiguration : IEntityTypeConfiguration<Hotel>
    {
        public void Configure(EntityTypeBuilder<Hotel> builder)
        {
            // Primary Key
            builder.HasKey(h => h.HotelId);

            // Properties
            builder.Property(h => h.HotelId)
                .ValueGeneratedOnAdd();

            builder.Property(h => h.StarRating)
            .HasConversion<int>();

            builder.Property(h => h.Name)
                .IsRequired();

            builder.Property(h => h.Price)
                .IsRequired();

            // Relationships and Constraints
            builder.HasMany(h => h.Rooms)
                .WithOne(r => r.Hotel)
                .HasForeignKey(r => r.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(h => h.Images)
                .WithOne(i => i.Hotel)
                .HasForeignKey(i => i.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasMany(h => h.Reviews)
                .WithOne(r => r.Hotel)
                .HasForeignKey(r => r.HotelId)
                .OnDelete(DeleteBehavior.Cascade);

            // Seed Data
            builder.HasData(SeedData.SeedHotels());

            // Table Name
            builder.ToTable("Hotel");
        }
    }
}
