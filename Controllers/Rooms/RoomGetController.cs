using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Rooms;

[ApiController]
[Route("api/[controller]")]
public class RoomGetController(IRoomRepository roomRepository, ICheckExistRepository checkExistRepository) : RoomController(roomRepository, checkExistRepository)
{
}