using PruebaTecnica.Data;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Services;

public class CheckExistService(AppDbContext context) : GeneralService(context), ICheckExistRepository
{
    public async Task<bool> CheckExistBooking(int id)
    {
        if (await _context.Bookings.FindAsync(id) == null)
        {
            return false;
        }
        return true;
    }

    public async Task<bool> CheckExistEmployee(int id)
    {
        if (await _context.Employees.FindAsync(id) == null)
        {
            return false;
        }
        return true;
    }

    public async Task<bool> CheckExistGuest(int id)
    {
        if (await _context.Guests.FindAsync(id) == null)
        {
            return false;
        }
        return true;
    }

    public async Task<bool> CheckExistRoom(int id)
    {
        if (await _context.Rooms.FindAsync(id) == null)
        {
            return false;
        }
        return true;
    }

    public async Task<bool> CheckExistRoomType(int id)
    {
        if (await _context.RoomTypes.FindAsync(id) == null)
        {
            return false;
        }
        return true;    
    }
}