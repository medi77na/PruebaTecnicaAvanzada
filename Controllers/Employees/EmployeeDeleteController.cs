using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Employees;

[ApiController]
[Route("api/[controller]")]
[Tags("Employee")]
public class EmployeeDeleteController(IEmployeeRepository employeeRepository, ICheckExistRepository checkExistRepository) : EmployeeController(employeeRepository, checkExistRepository)
{
    [HttpDelete]
    public async Task<IActionResult> DeleteEmployee(int id)
    {
        if (!await _checkRepository.CheckExistEmployee(id))
        {
            return NotFound("El empleado no existe");
        }

        await _employeeRepository.Delete(await _employeeRepository.GetById(id));

        return NoContent();
    }
}