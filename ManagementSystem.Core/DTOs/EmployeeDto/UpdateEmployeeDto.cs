namespace ManagementSystem.Core.DTOs.EmployeeDto;

public class UpdateEmployeeDto
{
    public string? FirstName { get; set; } = string.Empty;
    public string? LastName { get; set; } = string.Empty;
    public string? Email { get; set; } = string.Empty;
    public string? PhoneNumber { get; set; } = string.Empty;
    public decimal? Salary { get; set; }

    public int? DepartmentId { get; set; }
    public int? PositionId { get; set; }
    public DateTime UpdatetedAt { get; set; } = DateTime.Now;
}
