using ManagementSystem.Api.Data;
using ManagementSystem.Core.DTOs.PositionDto;
using ManagementSystem.Core.Entities;
using ManagementSystem.Core.Interfaces;
using ManagementSystem.Core.Requests;
using ManagementSystem.Core.Responses;
using Microsoft.EntityFrameworkCore;

namespace ManagementSystem.Api.Services;

public class PositionService(ApplicationDbContext context) : IPositionService
{
    public async Task<Response<Position?>> CreatePositionAsync(CreatePositionDto createPosition)
    {
        try
        {
            var existingPosition = await context
                .Positions
                .FirstOrDefaultAsync(x => x.Name == createPosition.Name);

            if (existingPosition != null)
            {
                return new Response<Position?>(
                    null,
                    code: 400,
                    message: "Cargo já existente.");
            }

            var existingDepartment = await context.Departments.FirstOrDefaultAsync(x => x.Id == createPosition.DepartmentId);

            if (existingDepartment == null)
            {
                return new Response<Position?>(
                    null,
                    code: 400,
                    message: "Departamento não encontrado.");
            }

            var newPosition = new Position
            {
                Name = createPosition.Name,
                DepartmentId = createPosition.DepartmentId
            };

            context.Positions.Add(newPosition);
            await context.SaveChangesAsync();

            return new Response<Position?>(
                newPosition,
                code: 201,
                message: "Cargo criado com sucesso!");
        }
        catch (Exception ex)
        {
            return new Response<Position?>(
                null, 
                code: 500, 
                message: $"Erro interno do servidor. Detalhes do erro: {ex.Message}.");
        }
    }

    public async Task<Response<Position?>> UpdatePositionAsync(int id, UpdatePositionDto updatePosition)
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

    public async Task<Response<Position?>> GetPositionByIdAsync(int id)
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

    public async Task<PagedResponse<IEnumerable<Position?>>> GetAllPositionsAsync(PagedRequest pagedRequest)
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

    public async Task<Response<Position?>> DeletePositionAsync(int id)
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
