using ManagementSystem.Api.Data;
using ManagementSystem.Core.DTOs.EmployeeDto;
using ManagementSystem.Core.Entities;
using ManagementSystem.Core.Interfaces;
using ManagementSystem.Core.Requests;
using ManagementSystem.Core.Responses;

namespace ManagementSystem.Api.Services;

public class EmployeeService(ApplicationDbContext context) : IEmployeeService
{
    public async Task<Response<Employee?>> HireEmployeeAsync(HireEmployeeDto employeeDto)
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

    public async Task<Response<Employee?>> UpdateEmployeeAsync(int id, UpdateEmployeeDto employeeDto)
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

    public async Task<Response<Employee?>> ActiveEmployeeAsync(int id, ActiveEmployeeDto employeeDto)
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

    public async Task<Response<Employee?>> GetEmployeeByIdAsync(int id)
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

    public async Task<PagedResponse<IEnumerable<Employee?>>> GetAllEmployeesAsync(PagedRequest pagedRequest)
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

    public async Task<Response<Employee?>> ResignEmployeeAsync(int id)
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

    public async Task<Response<Employee?>> DeleteEmployeeAsync(int id)
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
