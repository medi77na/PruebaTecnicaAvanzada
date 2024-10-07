using PruebaTecnica.Dtos;

namespace PruebaTecnica.Repositories;

public interface IRoomRepository
{
    Task Add(RoomDto model);
    Task Update(RoomDto model);
    Task Delete(int id);
    Task<RoomDto?> GetById(int id);
    Task<List<RoomDto>> GetAll();
    Task<List<RoomDto>> GetByRoomNumber(string roomNumber);
    Task<List<RoomDto>> GetAvailableRooms();
    Task<List<RoomDto>> GetByType(int roomTypeId);
}