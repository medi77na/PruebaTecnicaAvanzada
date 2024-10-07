using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers;

[ApiController]
[Route("api/[controller]")]
public class GeneralController : ControllerBase
{
    protected readonly IMapper _mapper;
    protected readonly ICheckExistRepository _checkRepository;

    //Constructor with parameters
    public GeneralController(IMapper mapper, ICheckExistRepository checkRepository)
    {
        _mapper = mapper;
        _checkRepository = checkRepository;
    }

    //Constructor with parameters
    public GeneralController(ICheckExistRepository checkRepository)
    {
        _checkRepository = checkRepository;
    }

    //Constructor empty
    public GeneralController() { }
}