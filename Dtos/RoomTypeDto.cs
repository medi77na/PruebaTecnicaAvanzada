using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Dtos;

public class RoomTypeDto
{
    [Required]
    public string? Name { get; set; }
    public string? Description { get; set; }
}