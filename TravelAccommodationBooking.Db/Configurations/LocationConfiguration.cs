using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Utilities;

namespace TravelAccommodationBooking.Db.Configurations
{
    public class LocationConfiguration : IEntityTypeConfiguration<HotelLocation>
    {
        public void Configure(EntityTypeBuilder<HotelLocation> builder)
        {
            // Primary Key
            builder.HasKey(l => l.LocationId);

            // Properties
            builder.Property(l => l.LocationId)
                .ValueGeneratedOnAdd();

            builder.Property(l => l.Latitude)
                .HasColumnType("decimal(10, 8)")
                .IsRequired();

            builder.Property(l => l.Longitude)
                .HasColumnType("decimal(11, 8)")
                .IsRequired();

            // Seed Data
            builder.HasData(SeedData.SeedLocations());

            // Table Name
            builder.ToTable("Location");
        }
    }
}

