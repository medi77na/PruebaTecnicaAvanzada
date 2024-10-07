using PruebaTecnica.Dtos;
using PruebaTecnica.Models;

namespace PruebaTecnica.Repositories;

public interface IEmployeeRepository
{
    Task Add(Employee model);
    Task Update(Employee model);
    Task Delete(Employee model);
    Task<Employee?> GetById(int id);
    Task<Employee> GetByEmail(string email);
    Task<List<Employee>> GetAll();
}