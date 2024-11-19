using ManagementSystem.Core.DTOs.PositionDto;
using ManagementSystem.Core.Interfaces;
using ManagementSystem.Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class PositionController(
    IPositionService positionService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreatePosition(CreatePositionDto createPosition)
    {
        return Ok();
    }

    [HttpPut("{positionId}")]
    public async Task<IActionResult> UpdatePosition(int positionId, UpdatePositionDto updatePosition)
    {
        return Ok();
    }

    [HttpGet("{positionId}")]
    public async Task<IActionResult> GetPositionById(int positionId)
    {
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllPositions([FromQuery] PagedRequest pagedRequest)
    {
        return Ok();
    }

    [HttpDelete("{positionId}")]
    public async Task<IActionResult> DeletePosition(int positionId)
    {
        return Ok();
    }
}
