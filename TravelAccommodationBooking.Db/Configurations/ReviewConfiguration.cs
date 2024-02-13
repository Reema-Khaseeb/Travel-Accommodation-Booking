using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db.Configurations
{
    public class ReviewConfiguration : IEntityTypeConfiguration<Review>
    {
        public void Configure(EntityTypeBuilder<Review> builder)
        {
            // Primary Key
            builder.HasKey(hr => hr.ReviewId);

            // Relationships and Constraints
            builder.HasOne(r => r.User)
               .WithMany(u => u.Reviews)
               .HasForeignKey(r => r.UserId);

            // Properties
            builder.Property(r => r.ReviewId)
                .ValueGeneratedOnAdd();

            builder.Property(hr => hr.ReviewContent)
                .IsRequired()
                .HasMaxLength(100);
            
            builder.Property(hr => hr.ReviewDate)
                .IsRequired();

            // Table Name in Database
            builder.ToTable("Review");
        }
    }
}
