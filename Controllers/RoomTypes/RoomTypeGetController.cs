using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.RoomTypes;

[ApiController]
[Route("api/[controller]")]
[Tags("RoomType")]
public class RoomTypeGetController(IRoomTypeRepository roomTypeRepository, ICheckExistRepository checkExistRepository) : RoomTypeController(roomTypeRepository, checkExistRepository)
{
    [HttpGet]
    public async Task<ActionResult<List<RoomType>>> GetRoomsTypeAll()
    {
        return Ok(await _roomTypeRepository.GetAll());
    }

    [HttpGet("Id")]
    public async Task<ActionResult<RoomType>> GetRoomTypeById(int id)
    {
        if (!await _checkRepository.CheckExistRoom(id))
        {
            return NotFound("No se encontró ningun tipo de habitación con ese ID.");
        }
        return Ok(await _roomTypeRepository.GetById(id));
    }
}