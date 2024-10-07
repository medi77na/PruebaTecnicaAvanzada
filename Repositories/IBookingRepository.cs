using PruebaTecnica.Dtos;
using PruebaTecnica.Models;

namespace PruebaTecnica.Repositories;

public interface IBookingRepository
{
    Task Add(Booking model);
    Task<IEnumerable<Booking>> GetAll();
    Task<Booking> GetById(int id);
    Task Update(Booking model);
    Task Delete(Booking model);
}