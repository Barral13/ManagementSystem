using ManagementSystem.Core.Entities;

namespace ManagementSystem.Core.DTOs.EmployeeDto;

public class ActiveEmployeeDto
{
    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
    public int PositionId { get; set; }
    public Position Position { get; set; } = null!;
    public decimal Salary { get; set; }
    public DateTime ActivatedAt { get; set; } = DateTime.Now;
}
