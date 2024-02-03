using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Travel_Booking_Platform.Infrastructure.Rooms;

public class RoomConfiguration : IEntityTypeConfiguration<Room>
{
    public void Configure(EntityTypeBuilder<Room> builder)
    {
        builder.HasKey(r => r.Id);

        builder.Property(r => r.Capacity)
            .IsRequired();
        
        builder.Property(r => r.PricePerNight)
            .IsRequired();
        
        builder.Property(r => r.Number)
            .HasMaxLength(50)
            .IsRequired();
        
    }
}