using Travel_Booking_Platform.Infrastructure.Hotels;

namespace Travel_Booking_Platform.Infrastructure.Cities;

public class City
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Country { get; set; }

    public ICollection<Hotel> Hotels { get; set; } = new List<Hotel>();
}