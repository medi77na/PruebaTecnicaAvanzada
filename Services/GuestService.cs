using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Services;

public class GuestService(AppDbContext context) : GeneralService(context), IGuestRepository
{
    public async Task Add(Guest model)
    {
        await _context.Guests.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Guest model)
    {
        _context.Guests.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Guest>> GetAll()
    {
        return await _context.Guests.ToListAsync();
    }

    public async Task<Guest?> GetById(int id)
    {
        return await _context.Guests.FindAsync(id);
    }

    public async Task Update(Guest model)
    {
        _context.Entry(model).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}