using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db.Configurations
{
    public class PaymentConfiguration : IEntityTypeConfiguration<Payment>
    {
        public void Configure(EntityTypeBuilder<Payment> builder)
        {
            // Primary Key
            builder.HasKey(b => b.PaymentId);

            // Properties
            builder.Property(p => p.PaymentId)
                .ValueGeneratedOnAdd();

            builder.Property(p => p.Amount)
                .HasColumnType("decimal(10, 2)")
                .IsRequired();
            
            builder.Property(p => p.PaymentDate)
                .HasColumnType("decimal(10, 2)")
                .IsRequired();

            builder.Property(p => p.Status)
                .HasColumnType("decimal(10, 2)")
                .IsRequired();

            // Relationships and Constraints
            builder.HasOne(p => p.Booking)
                .WithOne(b => b.Payment)
                .HasForeignKey<Payment>(p => p.BookingId);

            // Table Name in Database
            builder.ToTable("Payment");
        }
    }
}
