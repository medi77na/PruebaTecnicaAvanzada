using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Dtos;

public class BookingDto
{
    [Required]
    public int RoomId { get; set; }

    [Required]
    public int GuestId { get; set; }

    [Required]
    public int EmployeeId { get; set; }

    [Required]
    public DateOnly StartDate { get; set; }

    public DateOnly EndDate { get; set; }
}