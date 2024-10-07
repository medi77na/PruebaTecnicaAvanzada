using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.Rooms;

[ApiController]
[Route("api/[controller]")]
public class RoomController : GeneralController
{
    protected readonly IRoomRepository _roomRepository;

    public RoomController(IRoomRepository roomRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : base(mapper,checkExistRepository)
    {
        _roomRepository = roomRepository; 
    }

    public RoomController(IRoomRepository roomRepository, ICheckExistRepository checkExistRepository) : base(checkExistRepository)
    {
        _roomRepository = roomRepository; 
    }
}