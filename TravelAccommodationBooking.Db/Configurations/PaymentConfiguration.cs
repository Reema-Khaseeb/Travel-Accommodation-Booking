using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Utilities;

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
                .IsRequired();

            builder.Property(p => p.Status)
                .IsRequired();

            // Seed Data
            builder.HasData(SeedData.SeedPayments());

            // Table Name in Database
            builder.ToTable("Payment");
        }
    }
}
