using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dtos;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Employees;

[ApiController]
[Route("api/[controller]")]
[Tags("Employee")]
public class EmployeePostController(IEmployeeRepository employeeRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : EmployeeController(employeeRepository, mapper, checkExistRepository)
{

    [HttpPost]
    public async Task<ActionResult> CreateEmployee(EmployeeDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest($"Modelo inválido. {model}");
        }

        var employee = _mapper.Map<Employee>(model);

        // Create PasswordHasher<User> instance
        var passwordHasher = new PasswordHasher<Employee>();

        // Hash the password and assign it to the user's Password property
        employee.Password = passwordHasher.HashPassword(employee, model.Password);

        await _employeeRepository.Add(employee);

        return Ok(employee);
    }
}