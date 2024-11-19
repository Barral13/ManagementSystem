using ManagementSystem.Core.DTOs.PositionDto;
using ManagementSystem.Core.Entities;
using ManagementSystem.Core.Requests;
using ManagementSystem.Core.Responses;

namespace ManagementSystem.Core.Interfaces;

public interface IPositionService
{
    Task<Response<Position?>> CreatePositionAsync(CreatePositionDto createPosition);
    Task<Response<Position?>> UpdatePositionAsync(int positionId, UpdatePositionDto updatePosition);
    Task<Response<Position?>> GetPositionByIdAsync(int positionId);
    Task<PagedResponse<IEnumerable<Position?>>> GetAllPositionsAsync(PagedRequest pagedRequest);
    Task<Response<Position?>> DeletePositionAsync(int positionId);
}
