using PruebaTecnica.Dtos;

namespace PruebaTecnica.Repositories;

public interface IRoomTypeRepository
{
    Task Add(RoomTypeDto model);
    Task<IEnumerable<RoomTypeDto>> GetAll();
    Task<RoomTypeDto?> GetById(int id);
    Task Update(RoomTypeDto model);
    Task Delete(int id);
}