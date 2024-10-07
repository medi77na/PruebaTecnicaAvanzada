using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Employees;

[ApiController]
[Route("api/[controller]")]
public class EmployeePutController(IEmployeeRepository employeeRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : EmployeeController(employeeRepository, mapper, checkExistRepository)
{


}