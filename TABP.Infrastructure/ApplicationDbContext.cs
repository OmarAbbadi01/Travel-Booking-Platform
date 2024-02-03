using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Travel_Booking_Platform.Infrastructure.Cities;
using Travel_Booking_Platform.Infrastructure.Hotels;
using Travel_Booking_Platform.Infrastructure.Rooms;

namespace Travel_Booking_Platform.Infrastructure;

public class ApplicationDbContext : DbContext
{
    public DbSet<City> Cities { get; set; }

    public DbSet<Hotel> Hotels { get; set; }

    public DbSet<Room> Rooms { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}