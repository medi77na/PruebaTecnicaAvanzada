using PruebaTecnica.Dtos;

namespace PruebaTecnica.Repositories;

public interface IBookingRepository
{
    Task Add(BookingDto model);
    Task<IEnumerable<BookingDto>> GetAll();
    Task<BookingDto> GetById(int id);
    Task Update(BookingDto model);
    Task Delete(int id);
}