using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Employees;

[ApiController]
[Route("api/[controller]")]
public class EmployeeGetController(IEmployeeRepository employeeRepository, ICheckExistRepository checkExistRepository) : EmployeeController(employeeRepository,checkExistRepository)
{
}