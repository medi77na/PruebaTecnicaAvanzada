using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dtos;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Employees;

[ApiController]
[Route("api/[controller]")]
[Tags("Employee")]
public class EmployeePutController(IEmployeeRepository employeeRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : EmployeeController(employeeRepository, mapper, checkExistRepository)
{
    [HttpPut]
    public async Task<ActionResult> UpdateRoom(int id, EmployeeDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest($"Modelo inválido. {model}");
        }

        if (!await _checkRepository.CheckExistEmployee(id))
        {
            return NotFound("No existe el usuario señalado.");
        }

        var employee = await _employeeRepository.GetById(id);

        _mapper.Map(model, employee);

        await _employeeRepository.Update(employee);

        return Ok(employee);
    }
}