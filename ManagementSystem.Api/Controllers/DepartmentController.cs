using ManagementSystem.Core.DTOs.DepartmentDto;
using ManagementSystem.Core.Interfaces;
using ManagementSystem.Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartmentController(
    IDepartmentService departmentService) : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> CreateDepartment(CreateDepartmentDto createDepartment)
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

        var response = await departmentService.CreateDepartmentAsync(createDepartment);

        if (response.IsSuccess)
        {
            return CreatedAtAction(nameof(GetDepartmentById),
                new
                {
                    department = response.Data,
                    message = response.Message
                },
                new { departmentId = response.Data?.Id });
        }

        return StatusCode(response.Code, new
        {
            message = response.Message
        });
    }


    [HttpPut("{departmentId}")]
    public async Task<IActionResult> UpdateDepartment(int departmentId, UpdateDepartmentDto updateDepartment)
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

        var response = await departmentService.UpdateDepartmentAsync(departmentId, updateDepartment);

        if (response.Code == 200)
            return Ok( new
                { data = response.Data, message = response.Message });

        if (response.Code == 404)
            return NotFound(new { message = response.Message });

        return StatusCode(500, new { message = response.Message });
    }


    [HttpGet("{departmentId}")]
    public async Task<IActionResult> GetDepartmentById(int departmentId)
    {
        var response = await departmentService.GetDepartmentByIdAsync(departmentId);

        if (response.Code == 200)
            return Ok(new
            { data = response.Data, message = response.Message });

        if (response.Code == 404)
            return NotFound(new { message = response.Message });

        return StatusCode(500, new { message = response.Message });
    }


    [HttpGet]
    public async Task<IActionResult> GetAllDepartments([FromQuery] PagedRequest pagedRequest)
    {
        return Ok();
    }


    [HttpDelete("{departmentId}")]
    public async Task<IActionResult> DeleteDepartment(int departmentId)
    {
        return Ok();
    }
}
