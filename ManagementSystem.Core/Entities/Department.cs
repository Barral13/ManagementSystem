namespace ManagementSystem.Core.Entities;

public class Department
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;

    public IEnumerable<Position> Positions { get; set; } = new List<Position>();
    public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
}