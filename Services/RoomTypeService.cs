using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Services;

public class RoomTypeService(AppDbContext context) : GeneralService(context), IRoomTypeRepository
{
    public async Task Add(RoomType model)
    {
        await _context.RoomTypes.AddAsync(model);
        await _context.SaveChangesAsync();
    }


    public async Task Delete(RoomType model)
    {
        _context.RoomTypes.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<IEnumerable<RoomType>> GetAll()
    {
        return await _context.RoomTypes.ToListAsync();
    }

    public async Task<RoomType?> GetById(int id)
    {
        return await _context.RoomTypes.FindAsync(id);
    }

    public async Task Update(RoomType model)
    {
        _context.Entry(model).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}