using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dtos;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Rooms;

[ApiController]
[Route("api/[controller]")]
public class RoomPostController(IRoomRepository roomRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : RoomController(roomRepository, mapper, checkExistRepository)
{

    [HttpPost]
    public async Task<ActionResult> CreateRoom(RoomDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest($"Modelo inválido. {model}");
        }

        if (!await _checkRepository.CheckExistRoomType(model.RoomTypeId))
        {
            return BadRequest($"Tipo de cuarto no existente. {model}");
        }

        if (model.MaxOccupancyPersons <= 0)
        {
            return BadRequest($"La cantidad de personas no puede ser 0. {model}");
        }

        var room = _mapper.Map<Room>(model);

        await _roomRepository.Add(room);

        return Ok(room);
    }
}