using ManagementSystem.Core.DTOs.EmployeeDto;
using ManagementSystem.Core.Requests;
using Microsoft.AspNetCore.Mvc;

namespace ManagementSystem.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class EmployeeController : ControllerBase
{
    [HttpPost]
    public async Task<IActionResult> HireEmployee(HireEmployeeDto hireEmployee)
    {
        return Ok();
    }

    [HttpPut("{employeeId}")]
    public async Task<IActionResult> UpdateEmployee(int employeeId, UpdateEmployeeDto updateEmployee)
    {
        return Ok();
    }

    [HttpPut("{employeeId}/activate")]
    public async Task<IActionResult> ActiveEmployee(int employeeId, ActiveEmployeeDto activeEmployee)
    {
        return Ok();
    }

    [HttpGet("{employeeId}")]
    public async Task<IActionResult> GetEmployeeById(int employeeId)
    {
        return Ok();
    }

    [HttpGet]
    public async Task<IActionResult> GetAllEmployees([FromQuery] PagedRequest pagedRequest)
    {
        return Ok();
    }

    [HttpPut("{employeeId}/resign")]
    public async Task<IActionResult> ResignEmployee(int employeeId)
    {
        return Ok();
    }

    [HttpDelete("{employeeId}")]
    public async Task<IActionResult> DeleteEmployee(int employeeId)
    {
        return Ok();
    }
}
