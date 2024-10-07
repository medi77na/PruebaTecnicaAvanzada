using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.RoomTypes;

[ApiController]
[Route("api/[controller]")]
public class RoomTypeGetController(IRoomTypeRepository roomTypeRepository, ICheckExistRepository checkExistRepository) : RoomTypeController(roomTypeRepository, checkExistRepository)
{
}