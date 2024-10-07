using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Dtos;

public class GuestDto
{
    [MaxLength(100)]
    [Required]
    public string? FirstName { get; set; }

    [MaxLength(100)]
    [Required]
    public string? LastName { get; set; }

    [MaxLength(255)]
    [EmailAddress]
    [Required]
    public string? Email { get; set; }

    [MaxLength(20)]
    [RegularExpression(@"^\d{9,10}$")]
    [Required]
    public string? IdentificationNumber { get; set; }

    [MaxLength(20)]
    [Phone]
    [Required]
    public string? PhoneNumber { get; set; }

    public string? BirthDate { get; set; }
}