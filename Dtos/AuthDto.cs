using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Dtos;

public class AuthDto
{
    [Required]
    [EmailAddress]
    public string? Email { get; set; }
    
    [DataType(DataType.Password)]
    [Required]
    public string? Password { get; set; }
}