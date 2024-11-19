using ManagementSystem.Core.DTOs.DepartmentDto;
using ManagementSystem.Core.Interfaces;
using ManagementSystem.Core.Requests;
using ManagementSystem.Core.Responses;
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
        return Ok();
    }

    [HttpPut("{departmentId}")]
    public async Task<IActionResult> UpdateDepartment(int departmentId, UpdateDepartmentDto updateDepartment)
    {
        return Ok();
    }

    [HttpGet("{departmentId}")]
    public async Task<IActionResult> GetDepartmentById(int departmentId)
    {
        return Ok();
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
