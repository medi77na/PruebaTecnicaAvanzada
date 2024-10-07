namespace PruebaTecnica.Repositories;

public interface ICheckExistenceRepository
{
    Task<bool> CheckExistenceBooking(int id);
    Task<bool> CheckExistenceGuest(int id);
    Task<bool> CheckExistenceRoom(int id);
    Task<bool> CheckExistenceRoomType(int id);
    Task<bool> CheckExistenceEmployee(int id);
}