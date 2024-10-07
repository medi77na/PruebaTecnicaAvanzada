using PruebaTecnica.Dtos;

namespace PruebaTecnica.Repositories;

public interface IGuestRepository
{
    Task Add(GuestDto model);
    Task Update(GuestDto model);
    Task Delete(int id);
    Task<GuestDto> GetById(int id);
    Task<List<GuestDto>> GetAll();
}