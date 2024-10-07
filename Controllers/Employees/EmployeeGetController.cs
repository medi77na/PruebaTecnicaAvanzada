using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Employees;

[ApiController]
[Route("api/[controller]")]
public class EmployeeGetController(IEmployeeRepository employeeRepository, ICheckExistRepository checkExistRepository) : EmployeeController(employeeRepository, checkExistRepository)
{

    [HttpGet]
    public async Task<ActionResult<List<Employee>>> GetAllEmployees()
    {
        return Ok(await _employeeRepository.GetAll());
    }

    public async Task<ActionResult<Employee>> GetEmployeeById(int id)
    {
        if (!await _checkRepository.CheckExistRoom(id))
        {
            return NotFound("No se encontró ningun empleado con ese ID.");
        }
        return Ok(await _employeeRepository.GetById(id));
    }


}