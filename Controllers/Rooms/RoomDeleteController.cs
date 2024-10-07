using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Rooms;

[ApiController]
[Route("api/[controller]")]
public class RoomDeleteController(IRoomRepository roomRepository, ICheckExistRepository checkExistRepository) : RoomController(roomRepository, checkExistRepository)
{
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        if (!await _checkRepository.CheckExistRoom(id))
        {
            return NotFound("La habitación no existe");
        }

        await _roomRepository.Delete(await _roomRepository.GetById(id));

        return NoContent();
    }
}