using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Guests;

[ApiController]
[Route("api/[controller]")]
[Tags("Guest")]
public class GuestDeleteController(IGuestRepository guestRepository, ICheckExistRepository checkExistRepository) : GuestController(guestRepository, checkExistRepository)
{
    [HttpDelete]
    public async Task<IActionResult> DeleteGuest(int id)
    {
        if (!await _checkRepository.CheckExistGuest(id))
        {
            return NotFound("El huesped no existe");
        }

        await _guestRepository.Delete(await _guestRepository.GetById(id));

        return NoContent();
    }
}