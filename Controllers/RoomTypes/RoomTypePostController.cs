using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Dtos;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.RoomTypes;

[ApiController]
[Route("api/[controller]")]
[Tags("RoomType")]
public class RoomTypePostController(IRoomTypeRepository roomTypeRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : RoomTypeController(roomTypeRepository, mapper, checkExistRepository)
{
    [HttpPost]
    public async Task<ActionResult> CreateRoomType(RoomTypeDto model)
    {
        if (!ModelState.IsValid)
        {
            return BadRequest($"Modelo inválido. {model}");
        }

        var roomType = _mapper.Map<RoomType>(model);

        await _roomTypeRepository.Add(roomType);

        return Ok(roomType);
    }
}