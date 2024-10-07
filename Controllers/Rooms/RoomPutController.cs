using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dtos;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Rooms;

[ApiController]
[Route("api/[controller]")]
public class RoomPutController(IRoomRepository roomRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : RoomController(roomRepository, mapper, checkExistRepository)
{

    [HttpPut]
    public async Task<ActionResult> UpdateRoom(int id, RoomDto model)
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

        if (!await _checkRepository.CheckExistRoom(id))
        {
            return NotFound("No existe la habitación señalada.");
        }

        var room = await _roomRepository.GetById(id);

        _mapper.Map(model, room);

        await _roomRepository.Update(room);

        return Ok(room);
    }
}