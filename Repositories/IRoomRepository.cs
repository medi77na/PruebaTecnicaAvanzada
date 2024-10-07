using PruebaTecnica.Dtos;
using PruebaTecnica.Models;

namespace PruebaTecnica.Repositories;

public interface IRoomRepository
{
    Task Add(Room model);
    Task Update(Room model);
    Task Delete(Room model);
    Task<Room?> GetById(int id);
    Task<List<Room>> GetAll();
    Task<Room> GetByRoomNumber(string roomNumber);
    Task<List<Room>> GetAvailableRooms();
    Task<List<Room>> GetByType(int roomTypeId);
}