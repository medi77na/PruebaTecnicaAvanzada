using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Guests;

[ApiController]
[Route("api/[controller]")]
public class GuestPostController(IGuestRepository guestRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : GuestController(guestRepository, mapper, checkExistRepository)
{
}