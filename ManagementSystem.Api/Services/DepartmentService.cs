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
    public async Task<Response<Department?>> CreateDepartmentAsync(CreateDepartmentDto departmentDto)
    {
        try
        {
            var existingDepartment = await context.Departments
                .FirstOrDefaultAsync(x => x.Name == departmentDto.Name);

            if (existingDepartment != null)
                return new Response<Department?>(null, code: 400, message: "Departamento já existente.");

            var newDepartment = new Department
            {
                Name = departmentDto.Name,
            };

            context.Departments.Add(newDepartment);
            await context.SaveChangesAsync();

            return new Response<Department?>(newDepartment, code: 201, message: "Departamento criado com sucesso!");
        }
        catch (Exception ex)
        {
            return new Response<Department?>(null,
                        code: 500,
                        message: $"Erro interno do servidor ao tentar criar o departamento. Detalhes do erro: {ex.Message}. " +
                                 "Por favor, entre em contato com o suporte.");
        }
    }


    public async Task<Response<Department?>> UpdateDepartmentAsync(int id, UpdateDepartmentDto departmentDto)
    {
        try
        {
            var existingDepartment = await context.Departments
                .FirstOrDefaultAsync(x => x.Id == id);

            if (existingDepartment == null)
                return new Response<Department?>(null, code: 404, message: "Departamento não encontrado.");

            existingDepartment.Name = departmentDto.Name;

            context.Departments.Update(existingDepartment);
            await context.SaveChangesAsync();

            return new Response<Department?>(existingDepartment,
                code: 200,
                message: "Departamento atualizado com sucesso!");
        }
        catch (Exception ex)
        {
            return new Response<Department?>(null,
                        code: 500,
                        message: $"Erro interno do servidor ao tentar atualizar o departamento. Detalhes do erro: {ex.Message}. " +
                                 "Por favor, entre em contato com o suporte.");
        }
    }

    public async Task<Response<Department?>> GetDepartmentByIdAsync(int id)
    {
        try
        {
            var existingDepartment = await context.Departments
                .FirstOrDefaultAsync(x => x.Id == id);

            if (existingDepartment == null)
                return new Response<Department?>(null, code: 404, message: "Departamento não encontrado.");

            return new Response<Department?>(existingDepartment,
                code: 200,
                message: $"Departamento encontrado: {existingDepartment.Name}");
        }
        catch (Exception ex)
        {
            return new Response<Department?>(null,
                        code: 500,
                        message: $"Erro interno do servidor ao buscar departamento.         Detalhes do erro: {ex.Message}. " +
                                 "Por favor, entre em contato com o suporte.");
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
