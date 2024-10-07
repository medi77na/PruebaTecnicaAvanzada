using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Employees;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : GeneralController
{
    protected readonly IEmployeeRepository _employeeRepository;

    public EmployeeController(IEmployeeRepository employeeRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : base(mapper,checkExistRepository)
    {
        _employeeRepository = employeeRepository;
    }

    public EmployeeController(IEmployeeRepository employeeRepository, ICheckExistRepository checkExistRepository) : base(checkExistRepository)
    {
        _employeeRepository = employeeRepository;
    }
}