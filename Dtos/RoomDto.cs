using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Dtos;

public class RoomDto
{
    [Required]
    public string? RoomNumber { get; set; }

    [Required]
    public int RoomTypeId { get; set; }

    [Required]
    public double PricePerNight { get; set; }

    [Required]
    public bool Availability { get; set; }

    [Required]
    public int MaxOccupancyPersons { get; set; }
}