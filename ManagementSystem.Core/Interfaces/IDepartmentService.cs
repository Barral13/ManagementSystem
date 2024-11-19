using ManagementSystem.Core.DTOs.DepartmentDto;
using ManagementSystem.Core.DTOs.PositionDto;
using ManagementSystem.Core.Entities;
using ManagementSystem.Core.Requests;
using ManagementSystem.Core.Responses;

namespace ManagementSystem.Core.Interfaces;

public interface IDepartmentService
{
    Task<Response<Department?>> CreateDepartmentAsync(CreateDepartmentDto departmentDto);
    Task<Response<Department?>> UpdateDepartmentAsync(int departmentId, UpdateDepartmentDto departmentDto);
    Task<Response<Department?>> GetDepartmentByIdAsync(int departmentId);
    Task<PagedResponse<IEnumerable<Department?>>> GetAllDepartmentsAsync(PagedRequest pagedRequest);
    Task<Response<Department?>> DeleteDepartmentAsync(int departmentId);
}

