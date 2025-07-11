using MVC_Area.Models.Northwind;

namespace MVC_Area.Repositories.Abstracts
{
    public interface IEmployeeRepository
    {
        Task<List<Employee>> GetAllAsync();
        Task<Employee> GetByIdAsync(int id);
        Task AddAsync(Employee employee);
        Task UpdateAsync(Employee employee);
        Task DeleteAsync(int id);
        Task<int> GetEmployeeCountAsync();


    }
}
