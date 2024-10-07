using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Services;

public class BookingServices(AppDbContext context) : GeneralService(context), IBookingRepository
{
    public async Task Add(Booking model)
    {
        await _context.Bookings.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Booking model)
    {
        _context.Bookings.Remove(model);
        await _context.SaveChangesAsync();    }

    public async Task<IEnumerable<Booking>> GetAll()
    {
        return await _context.Bookings.ToListAsync();    
    }

    public async Task<Booking?> GetById(int id)
    {
        return await _context.Bookings.FindAsync(id);
    }

    public async Task Update(Booking model)
    {
        _context.Entry(model).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}