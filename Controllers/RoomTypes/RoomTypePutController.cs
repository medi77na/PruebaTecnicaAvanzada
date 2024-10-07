using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dtos;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.RoomTypes;

[ApiController]
[Route("api/[controller]")]
[Tags("RoomType")]
public class RoomTypePutController(IRoomTypeRepository roomTypeRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : RoomTypeController(roomTypeRepository, mapper, checkExistRepository)
{
    [HttpPut]
    public async Task<ActionResult> UpdateRoomType(int id, RoomTypeDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest($"Modelo inválido. {model}");
        }

        if (!await _checkRepository.CheckExistRoomType(id))
        {
            return NotFound("No existe el tipo de habitación señalado.");
        }

        var roomType = await _roomTypeRepository.GetById(id);

        _mapper.Map(model, roomType);

        await _roomTypeRepository.Update(roomType);

        return Ok(roomType);
    }
}