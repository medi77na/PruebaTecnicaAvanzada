using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Guests;

[ApiController]
[Route("api/[controller]")]
public class GuestDeleteController(IGuestRepository guestRepository, ICheckExistRepository checkExistRepository) : GuestController(guestRepository, checkExistRepository)
{
}