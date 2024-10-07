using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Controllers.RoomTypes;

[ApiController]
[Route("api/[controller]")]
public class RoomTypeController : GeneralController
{
    protected readonly IRoomTypeRepository _roomTypeRepository;

    public RoomTypeController(IRoomTypeRepository roomTypeRepository, IMapper mapper, ICheckExistRepository checkExistRepository) : base(mapper,checkExistRepository)
    {
        _roomTypeRepository = roomTypeRepository;
    }

    public RoomTypeController(IRoomTypeRepository roomTypeRepository, ICheckExistRepository checkExistRepository) : base(checkExistRepository)
    {
        _roomTypeRepository = roomTypeRepository;
    }
}