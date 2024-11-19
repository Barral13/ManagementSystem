using ManagementSystem.Api.Data;
using ManagementSystem.Core.DTOs.PositionDto;
using ManagementSystem.Core.Entities;
using ManagementSystem.Core.Interfaces;
using ManagementSystem.Core.Requests;
using ManagementSystem.Core.Responses;

namespace ManagementSystem.Api.Services;

public class PositionService(ApplicationDbContext context) : IPositionService
{
    public async Task<Response<Position?>> CreatePositionAsync(CreatePositionDto createPosition)
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
