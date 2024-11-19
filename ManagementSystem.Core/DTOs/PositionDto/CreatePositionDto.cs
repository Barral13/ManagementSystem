using ManagementSystem.Core.Entities;

namespace ManagementSystem.Core.DTOs.PositionDto;

public class CreatePositionDto
{
    public string Name { get; set; } = string.Empty;

    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
}
