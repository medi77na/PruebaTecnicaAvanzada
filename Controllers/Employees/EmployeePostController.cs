using AutoMapper;
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

        await _employeeRepository.Add(employee);

        return Ok(employee);
    }


}