using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dtos;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Guests;

[ApiController]
[Route("api/[controller]")]
[Tags("Guest")]
public class GuestPutController(IGuestRepository guestRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : GuestController(guestRepository, mapper, checkExistRepository)
{
    [Authorize]
    [HttpPut]
    public async Task<ActionResult> UpdateGuest(int id, GuestDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest($"Modelo inválido. {model}");
        }

        if (!await _checkRepository.CheckExistGuest(id))
        {
            return NotFound("No existe el huesped señalado.");
        }

        var guest = await _guestRepository.GetById(id);

        _mapper.Map(model, guest);

        await _guestRepository.Update(guest);

        return Ok(guest);
    }
}