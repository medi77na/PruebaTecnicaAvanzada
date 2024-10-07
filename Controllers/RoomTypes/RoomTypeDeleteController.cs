using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.RoomTypes;

[ApiController]
[Route("api/[controller]")]
[Tags("RoomType")]
public class RoomTypeDeleteController(IRoomTypeRepository roomTypeRepository, ICheckExistRepository checkExistRepository) : RoomTypeController(roomTypeRepository, checkExistRepository)
{
    [HttpDelete]
    public async Task<IActionResult> Delete(int id)
    {
        if (!await _checkRepository.CheckExistRoomType(id))
        {
            return NotFound("La tipo de habitación no existe");
        }

        await _roomTypeRepository.Delete(await _roomTypeRepository.GetById(id));

        return NoContent();
    }
}