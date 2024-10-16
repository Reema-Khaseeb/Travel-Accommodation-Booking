﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;
using TravelAccommodationBooking.Db.Utilities;

namespace TravelAccommodationBooking.Db.Configurations
{
    public class BookingConfiguration : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            // Primary Key
            builder.HasKey(b => b.BookingId);

            // Properties
            builder.Property(b => b.BookingId)
                .ValueGeneratedOnAdd();

            builder.Property(b => b.TotalPrice)
                .HasColumnType("decimal(10, 2)");

            builder.Property(b => b.CheckInDate)
                .IsRequired();

            builder.Property(b => b.CheckOutDate)
                .IsRequired();

            // Ensure CheckOutDate is after CheckInDate
            builder.HasCheckConstraint("CK_Booking_CheckOutDate_After_CheckInDate",
                "[CheckOutDate] > [CheckInDate]");
            
            // indexing
            builder.HasIndex(b =>
            new { b.RoomId, b.CheckInDate, b.CheckOutDate})
                .HasName("IX_Bookings_RoomId_CheckInDate_CheckOutDate")
                .IsUnique();

            // Seed Data
            builder.HasData(SeedData.SeedBookings());

            // Table Name in Database
            builder.ToTable("Booking");
        }
    }
}
