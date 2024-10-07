using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.RoomTypes;

[ApiController]
[Route("api/[controller]")]
public class RoomTypePutController(IRoomTypeRepository roomTypeRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : RoomTypeController(roomTypeRepository, mapper, checkExistRepository)
{
}