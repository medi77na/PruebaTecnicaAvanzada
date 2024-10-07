using System.ComponentModel.DataAnnotations;

namespace PruebaTecnica.Dtos;

public class EmployeeDto
{
    [Required]
    public string? FirstName { get; set; }

    [Required]
    public string? LastName { get; set; }

    [Required]
    [EmailAddress]
    public string? Email { get; set; }


    [RegularExpression(@"^\d{9,10}$")]
    [Required]
    public string? IdentificationNumber { get; set; }

    [DataType(DataType.Password)]
    [Required]
    public string? Password { get; set; }
}