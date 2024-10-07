using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Services;

public class RoomService(AppDbContext context) : GeneralService(context), IRoomRepository
{
    public async Task Add(Room model)
    {
        await _context.Rooms.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Room model)
    {
        _context.Rooms.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Room>> GetAll()
    {
        return await _context.Rooms.ToListAsync();
    }

    public async Task<List<Room>> GetAvailableRooms()
    {
        return await _context.Rooms.Where(r => r.Availability == true).ToListAsync();
    }

    public async Task<Room?> GetById(int id)
    {
        return await _context.Rooms.FindAsync(id);
    }

    public async Task<Room?> GetByRoomNumber(string roomNumber)
    {
        return await _context.Rooms.FirstOrDefaultAsync(r => r.RoomNumber == roomNumber);
    }

    public async Task<List<Room>> GetByType(int roomTypeId)
    {
        return await _context.Rooms.Where(r => r.RoomTypeId == roomTypeId).ToListAsync();
    }

    public async Task Update(Room model)
    {
        _context.Entry(model).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}