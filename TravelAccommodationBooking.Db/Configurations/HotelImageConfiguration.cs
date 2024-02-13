using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Utilities;

namespace TravelAccommodationBooking.Db.Configurations
{
    public class HotelImageConfiguration : IEntityTypeConfiguration<HotelImage>
    {
        // Configure entity properties, relationships
        public void Configure(EntityTypeBuilder<HotelImage> builder)
        {
            // Primary Key
            builder.HasKey(hi => hi.ImageId);

            // Properties
            builder.Property(h => h.ImageId)
                .ValueGeneratedOnAdd();

            builder.Property(h => h.ImageUrl)
                .IsRequired();

            // Seed Data
            builder.HasData(SeedData.SeedHotelImages());

            // Table Name in Database
            builder.ToTable("HotelImage");
        }
    }
}
