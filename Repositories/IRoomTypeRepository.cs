using PruebaTecnica.Models;

namespace PruebaTecnica.Repositories;

public interface IRoomTypeRepository
{
    Task Add(RoomType model);
    Task<IEnumerable<RoomType>> GetAll();
    Task<RoomType?> GetById(int id);
    Task Update(RoomType model);
    Task Delete(RoomType model);
}