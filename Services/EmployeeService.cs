using Microsoft.EntityFrameworkCore;
using PruebaTecnica.Data;
using PruebaTecnica.Models;
using PruebaTecnica.Repositories;

namespace PruebaTecnica.Services;

public class EmployeeService(AppDbContext context) : GeneralService(context), IEmployeeRepository
{
    public async Task Add(Employee model)
    {
        await _context.Employees.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Employee model)
    {
        _context.Employees.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Employee>> GetAll()
    {
        return await _context.Employees.ToListAsync();
    }

    public async Task<Employee?> GetById(int id)
    {
        return await _context.Employees.FindAsync(id);
    }

    public async Task Update(Employee model)
    {
        _context.Entry(model).State = EntityState.Modified;
        await _context.SaveChangesAsync();
    }
}