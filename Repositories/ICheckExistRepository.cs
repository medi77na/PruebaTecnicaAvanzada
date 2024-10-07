namespace PruebaTecnica.Repositories;

public interface ICheckExistRepository
{
    Task<bool> CheckExistBooking (int id);
    Task<bool> CheckExistGuest (int id);
    Task<bool> CheckExistRoom (int id);
    Task<bool> CheckExistRoomType (int id);
    Task<bool> CheckExistEmployee (int id);
}