using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.RoomTypes;

[ApiController]
[Route("api/[controller]")]
public class RoomTypePostController(IRoomTypeRepository roomTypeRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : RoomTypeController(roomTypeRepository, mapper, checkExistRepository)
{
}