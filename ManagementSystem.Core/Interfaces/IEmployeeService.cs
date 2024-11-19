using ManagementSystem.Core.DTOs.EmployeeDto;
using ManagementSystem.Core.Entities;
using ManagementSystem.Core.Requests;
using ManagementSystem.Core.Responses;

namespace ManagementSystem.Core.Interfaces;

public interface IEmployeeService
{
    Task<Response<Employee?>> HireEmployeeAsync(HireEmployeeDto employeeDto);
    Task<Response<Employee?>> UpdateEmployeeAsync(int employeeId, UpdateEmployeeDto employeeDto);
    Task<Response<Employee?>> ActiveEmployeeAsync(int employeeId, ActiveEmployeeDto employeeDto);
    Task<Response<Employee?>> GetEmployeeByIdAsync(int employeeId);
    Task<PagedResponse<IEnumerable<Employee?>>> GetAllEmployeesAsync(PagedRequest pagedRequest);
    Task<Response<Employee?>> ResignEmployeeAsync(int employeeId);
    Task<Response<Employee?>> DeleteEmployeeAsync(int employeeId);
}
