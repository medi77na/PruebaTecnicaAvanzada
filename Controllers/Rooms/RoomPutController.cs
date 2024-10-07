using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Rooms;

[ApiController]
[Route("api/[controller]")]
public class RoomPutController(IRoomRepository roomRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : RoomController(roomRepository, mapper, checkExistRepository)
{
}