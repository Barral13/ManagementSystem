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
        if (!ModelState.IsValid)
        {
            return BadRequest(new 
            {
                message = "Dados inválidos",
                errors = ModelState.Values
                    .SelectMany(x => x.Errors)
                    .Select(x => x.ErrorMessage)
            });
        }

        var response = await positionService.CreatePositionAsync(createPosition);

        if (response.IsSuccess)
        {
            return CreatedAtAction(nameof(GetPositionById), 
                new {positionId = response.Data?.Id},
                new {position = response.Data, message = response.Message });
        }

        return StatusCode(response.Code, new
        {
            message = response.Message
        });
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
