using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dtos;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Guests;

[ApiController]
[Route("api/[controller]")]
[Tags("Guest")]
public class GuestPostController(IGuestRepository guestRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : GuestController(guestRepository, mapper, checkExistRepository)
{
    [HttpPost]
    public async Task<ActionResult> CreateGuest(GuestDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest($"Modelo inválido. {model}");
        }

        var guest = _mapper.Map<Guest>(model);

        await _guestRepository.Add(guest);

        return Ok(guest);
    }
}