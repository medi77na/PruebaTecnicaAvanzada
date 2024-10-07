using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Rooms;

[ApiController]
[Route("api/[controller]")]
[Tags("Room")]
public class RoomGetController(IRoomRepository roomRepository, ICheckExistRepository checkExistRepository) : RoomController(roomRepository, checkExistRepository)
{
    [Authorize]
    [HttpGet]
    public async Task<ActionResult<List<Room>>> GetRoomsAll()
    {
        return Ok(await _roomRepository.GetAll());
    }
    [Authorize]
    [HttpGet("Id")]
    public async Task<ActionResult<Room>> GetRoomById(int id)
    {
        if (!await _checkRepository.CheckExistRoom(id))
        {
            return NotFound("No se encontró ninguna habitación con ese ID.");
        }
        return Ok(await _roomRepository.GetById(id));
    }

    [Authorize]
    [HttpGet("Available")]
    public async Task<ActionResult<List<Room>>> GetRoomsAvailable()
    {
        return Ok(await _roomRepository.GetAvailableRooms());
    }

    [HttpGet("Type")]
    public async Task<ActionResult<List<Room>>> GetRoomsByType(int roomTypeId)
    {
        if (!await _checkRepository.CheckExistRoomType(roomTypeId))
        {
            return BadRequest("No existe ese tipo de habitaciones.");
        }
        return Ok(await _roomRepository.GetByType(roomTypeId));
    }

    [HttpGet("ByNumber")]
    public async Task<ActionResult<Room>> GetRoomByNumber(string roomNumber)
    {
        var room = await _roomRepository.GetByRoomNumber(roomNumber);
        if (room == null)
        {
            return NotFound("No existe ese número de habitación.");
        }
        return Ok(room);
    }
}