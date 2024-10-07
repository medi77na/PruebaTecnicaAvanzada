using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dtos;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Employees;

[ApiController]
[Route("api/[controller]")]
public class EmployeePostController(IEmployeeRepository employeeRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : EmployeeController(employeeRepository, mapper, checkExistRepository)
{

    [HttpPost]
    public async Task<ActionResult> CreateEmployee(EmployeeDto model)
    {
        await _
    }
    
}