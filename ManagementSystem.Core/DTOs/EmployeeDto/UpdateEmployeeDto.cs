﻿namespace ManagementSystem.Core.DTOs.EmployeeDto;

public class UpdateEmployeeDto
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public string? PhoneNumber { get; set; }
    public decimal? Salary { get; set; }

    public int? DepartmentId { get; set; }
    public int? PositionId { get; set; }
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
