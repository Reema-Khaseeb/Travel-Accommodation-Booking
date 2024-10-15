using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Utilities;

namespace TravelAccommodationBooking.Db.Configurations;

public class FeaturedDealConfiguration : IEntityTypeConfiguration<FeaturedDeal>
{
    public void Configure(EntityTypeBuilder<FeaturedDeal> builder)
    {
        // Primary Key
        builder.HasKey(fd => fd.Id);

        // Properties
        builder.Property(fd => fd.Id)
            .ValueGeneratedOnAdd();

        builder.Property(fd => fd.DiscountPercentage)
            .IsRequired();

        builder.Property(fd => fd.StartDate)
            .IsRequired();

        builder.Property(fd => fd.EndDate)
            .IsRequired();

        // Relationships
        builder.HasOne(fd => fd.Hotel)
            .WithMany()
            .HasForeignKey(fd => fd.HotelId);

        // Seed Data
        builder.HasData(SeedData.SeedFeaturedDeals());

        // Table Name
        builder.ToTable("FeaturedDeal");
    }
}
