namespace ManagementSystem.Core.Entities;

public class Position
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;

    public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
}
