using PruebaTecnica.Dtos;
using PruebaTecnica.Models;

namespace PruebaTecnica.Repositories;

public interface IGuestRepository
{
    Task Add(Guest model);
    Task Update(Guest model);
    Task Delete(Guest model);
    Task<Guest> GetById(int id);
    Task<List<Guest>> GetAll();
}