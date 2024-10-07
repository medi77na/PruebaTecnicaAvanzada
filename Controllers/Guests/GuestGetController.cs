using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Guests;

[ApiController]
[Route("api/[controller]")]
[Tags("Guest")]
public class GuestGetController(IGuestRepository guestRepository, ICheckExistRepository checkExistRepository) : GuestController(guestRepository, checkExistRepository)
{

    [HttpGet]
    public async Task<ActionResult<List<Guest>>> GetGuestAll()
    {
        return Ok(await _guestRepository.GetAll());
    }

    [HttpGet("id")]
    public async Task<ActionResult<Guest>> GetGuestById(int id)
    {
        if (!await _checkRepository.CheckExistGuest(id))
        {
            return NotFound("No se encontró ninguna huesped con ese ID.");
        }
        return Ok(await _guestRepository.GetById(id));
    }
}