using ManagementSystem.Api.Data;
using ManagementSystem.Core.DTOs.DepartmentDto;
using ManagementSystem.Core.Entities;
using ManagementSystem.Core.Interfaces;
using ManagementSystem.Core.Requests;
using ManagementSystem.Core.Responses;

namespace ManagementSystem.Api.Services;

public class DepartmentService(ApplicationDbContext context) : IDepartmentService
{
    public async Task<Response<Department?>> CreateDepartmentAsync(CreateDepartmentDto departmentDto)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception)
        {

            throw;
        }
    }


    public async Task<Response<Department?>> UpdateDepartmentAsync(int id, UpdateDepartmentDto departmentDto)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<Response<Department?>> GetDepartmentByIdAsync(int id)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<PagedResponse<IEnumerable<Department?>>> GetAllDepartmentsAsync(PagedRequest pagedRequest)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception)
        {

            throw;
        }
    }

    public async Task<Response<Department?>> DeleteDepartmentAsync(int id)
    {
        try
        {
            throw new NotImplementedException();
        }
        catch (Exception)
        {

            throw;
        }
    }
}
