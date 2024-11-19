using ManagementSystem.Core.DTOs.DepartmentDto;
using ManagementSystem.Core.DTOs.PositionDto;
using ManagementSystem.Core.Entities;
using ManagementSystem.Core.Requests;
using ManagementSystem.Core.Responses;

namespace ManagementSystem.Core.Interfaces;

public interface IDepartmentService
{
    Task<Response<Department?>> CreateDepartmentAsync(CreateDepartmentDto departmentDto);
    Task<Response<Department?>> UpdateDepartmentAsync(int id, UpdateDepartmentDto departmentDto);
    Task<Response<Department?>> GetDepartmentByIdAsync(int id);
    Task<PagedResponse<IEnumerable<Department?>>> GetAllDepartmentsAsync(PagedRequest pagedRequest);
    Task<Response<Department?>> DeleteDepartmentAsync(int id);
}
