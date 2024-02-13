using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using TravelAccommodationBooking.Db.Models;

namespace TravelAccommodationBooking.Db.Configurations
{
    public class RoomConfiguration : IEntityTypeConfiguration<Room>
    {
        public void Configure(EntityTypeBuilder<Room> builder)
        {
            // Primary Key
            builder.HasKey(u => u.RoomId);

            // Properties
            builder.Property(r => r.RoomId)
                .ValueGeneratedOnAdd();

            builder.Property(r => r.Number)
                .IsRequired(); 
            
            builder.Property(r => r.RoomType)
                .IsRequired();

            builder.Property(r => r.AdultsCapacity)
                .IsRequired();

            builder.Property(r => r.ChildrenCapacity)
                .IsRequired();

            builder.Property(e => e.Price)
                .IsRequired()
                .HasColumnType("decimal(10, 2)");

            // Define SQL check constraints for capacity ranges
            builder.HasCheckConstraint("CK_Room_AdultsCapacity", "[AdultsCapacity] BETWEEN 1 AND 4");
            builder.HasCheckConstraint("CK_Room_ChildrenCapacity", "[ChildrenCapacity] BETWEEN 0 AND 2");

            // Table Name in Database
            builder.ToTable("Room");
        }
    }
}
