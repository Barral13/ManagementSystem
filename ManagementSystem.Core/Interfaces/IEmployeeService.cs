using ManagementSystem.Core.DTOs.EmployeeDto;
using ManagementSystem.Core.Entities;
using ManagementSystem.Core.Requests;
using ManagementSystem.Core.Responses;

namespace ManagementSystem.Core.Interfaces;

public interface IEmployeeService
{
    Task<Response<Employee?>> HireEmployeeAsync(HireEmployeeDto employeeDto);
    Task<Response<Employee?>> UpdateEmployeeAsync(int id, UpdateEmployeeDto employeeDto);
    Task<Response<Employee?>> ActiveEmployeeAsync(int id, ActiveEmployeeDto employeeDto);
    Task<Response<Employee?>> GetEmployeeByIdAsync(int id);
    Task<PagedResponse<IEnumerable<Employee?>>> GetAllEmployeesAsync(PagedRequest pagedRequest);
    Task<Response<Employee?>> ResignEmployeeAsync(int id);
    Task<Response<Employee?>> DeleteEmployeeAsync(int id);
}
