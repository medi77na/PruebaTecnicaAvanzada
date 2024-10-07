using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Employees;

[ApiController]
[Route("api/[controller]")]
public class EmployeeDeleteController(IEmployeeRepository employeeRepository, ICheckExistRepository checkExistRepository) : EmployeeController(employeeRepository,checkExistRepository)
{
}