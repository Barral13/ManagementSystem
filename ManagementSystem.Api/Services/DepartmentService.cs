using ManagementSystem.Api.Data;
using ManagementSystem.Core.DTOs.DepartmentDto;
using ManagementSystem.Core.Entities;
using ManagementSystem.Core.Interfaces;
using ManagementSystem.Core.Requests;
using ManagementSystem.Core.Responses;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Api.Services;

public class DepartmentService(ApplicationDbContext context) : IDepartmentService
{
    public async Task<Response<Department?>> CreateDepartmentAsync(CreateDepartmentDto createDepartment)
    {
        try
        {
            var existingDepartment = await context
                .Departments
                .FirstOrDefaultAsync(x => x.Name == createDepartment.Name);

            if (existingDepartment != null)
            {
                return new Response<Department?>(
                    null, 
                    code: 400,
                    message: "Departamento já existente.");
            }

            var newDepartment = new Department
            {
                Name = createDepartment.Name
            };

            context.Departments.Add(newDepartment);
            await context.SaveChangesAsync();

            return new Response<Department?>(
                newDepartment, 
                code: 201, 
                message: "Departamento criado com sucesso!");
        }
        catch (Exception ex)
        {
            return new Response<Department?>(
                null,
                code: 500,
                message: $"Erro interno do servidor. Detalhes do erro: {ex.Message}.");
        }
    }

    public async Task<Response<Department?>> UpdateDepartmentAsync(int id, UpdateDepartmentDto updateDepartment)
    {
        try
        {
            var department = await context
                .Departments
                .FirstOrDefaultAsync(x => x.Id == id);

            if (department == null)
            {
                return new Response<Department?>(
                    null, 
                    code: 404, 
                    message: "Departamento não encontrado.");
            }

            department.Name = updateDepartment.Name;

            context.Departments.Update(department);
            await context.SaveChangesAsync();

            return new Response<Department?>(
                department,
                code: 200,
                message: "Departamento atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            return new Response<Department?>(
                null,
                code: 500,
                message: $"Erro interno do servidor. Detalhes do erro: {ex.Message}.");
        }
    }

    public async Task<Response<Department?>> GetDepartmentByIdAsync(int id)
    {
        try
        {
            var existingDepartment = await context
                .Departments
                .FirstOrDefaultAsync(x => x.Id == id);

            if (existingDepartment == null)
            {
                return new Response<Department?>(
                    null, 
                    code: 404, 
                    message: "Departamento não encontrado.");
            }

            return new Response<Department?>(
                existingDepartment,
                code: 200,
                message: $"Departamento encontrado: {existingDepartment.Name}");
        }
        catch (Exception ex)
        {
            return new Response<Department?>(
                null,
                code: 500,
                message: $"Erro interno do servidor. Detalhes do erro: {ex.Message}.");
        }
    }

    public async Task<PagedResponse<IEnumerable<Department?>>> GetAllDepartmentsAsync(PagedRequest pagedRequest)
    {
        try
        {
            var query = context
                .Departments
                .AsNoTracking()
                .OrderBy(x => x.Name);

            var departments = await query
                .Skip((pagedRequest.PageNumber - 1) * pagedRequest.PageSize)
                .Take(pagedRequest.PageSize)
                .ToListAsync();

            var totalCount = await query.CountAsync();

            return new PagedResponse<IEnumerable<Department?>>(
                departments,
                totalCount,
                pagedRequest.PageNumber,
                pagedRequest.PageSize);
        }
        catch (Exception ex)
        {
            return new PagedResponse<IEnumerable<Department?>>(
                null,
                code: 500,
                message: $"Erro interno do servidor ao buscar departamentos. Detalhes do erro: {ex.Message}.");
        }
    }

    public async Task<Response<Department?>> DeleteDepartmentAsync(int id)
    {
        try
        {
            var department = await context
                .Departments
                .FirstOrDefaultAsync(x => x.Id == id);

            if (department == null)
            {
                return new Response<Department?>(
                    null, 
                    code: 404, 
                    message: "Departamento não encontrado.");
            }

            context.Departments.Remove(department);
            await context.SaveChangesAsync();

            return new Response<Department?>(
                department, 
                code: 200, 
                message: $"Departamento excluido com sucesso: {department.Name}");
        }
        catch (Exception ex)
        {
            return new Response<Department?>(
                null,
                code: 500,
                message: $"Erro interno do servidor. Detalhes do erro: {ex.Message}.");
        }
    }
}
