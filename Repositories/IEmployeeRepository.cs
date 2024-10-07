using PruebaTecnica.Dtos;

namespace PruebaTecnica.Repositories;

public interface IEmployeeRepository
{
    Task Add(EmployeeDto model);
    Task Update(EmployeeDto model);
    Task Delete(int id);
    Task<EmployeeDto?> GetById(int id);
    Task<List<EmployeeDto>> GetAll();
}