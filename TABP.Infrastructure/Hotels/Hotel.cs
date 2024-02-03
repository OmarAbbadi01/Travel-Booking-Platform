using System.ComponentModel.DataAnnotations;
using Travel_Booking_Platform.Infrastructure.Cities;
using Travel_Booking_Platform.Infrastructure.Rooms;

namespace Travel_Booking_Platform.Infrastructure.Hotels;

public class Hotel
{
    public int Id { get; set; }
    
    public string Name { get; set; }
    
    [Range(1, 5)]
    public short StarsRate { get; set; }

    public ICollection<Room> Rooms { get; set; } = new List<Room>();
    
    public City City { get; set; }
    
    public int CityId { get; set; }
}