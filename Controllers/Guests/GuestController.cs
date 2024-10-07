using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Guests;

[ApiController]
[Route("api/[controller]")]
public class GuestController : GeneralController
{
    protected readonly IGuestRepository _guestRepository;

    public GuestController(IGuestRepository guestRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : base(mapper,checkExistRepository)
    {
        _guestRepository = guestRepository;
    }

    public GuestController(IGuestRepository guestRepository, ICheckExistRepository checkExistRepository) : base(checkExistRepository)
    {
        _guestRepository = guestRepository;
    }
}