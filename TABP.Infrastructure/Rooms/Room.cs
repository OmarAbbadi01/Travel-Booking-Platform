using System.ComponentModel.DataAnnotations;
using Travel_Booking_Platform.Infrastructure.Hotels;

namespace Travel_Booking_Platform.Infrastructure.Rooms;

public class Room
{
    public int Id { get; set; }

    [Range(1, 10)]
    public short Capacity { get; set; }

    public float PricePerNight { get; set; }

    public string Number { get; set; }
    
    public Hotel Hotel { get; set; }

    public int HotelId { get; set; }
}