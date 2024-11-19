namespace ManagementSystem.Core.Entities;

public class Employee
{
    public int Id { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string Cpf { get; set; } = string.Empty;
    public decimal Salary { get; set; }

    public DateTime HiredAt { get; set; } = DateTime.Now;
    public DateTime UpdatetedAt { get; set; } = DateTime.Now;
    public DateTime ActivatedAt { get; set; } = DateTime.Now;
    public DateTime ResignedAt { get; set; } = DateTime.Now;

    public int DepartmentId { get; set; }
    public Department Department { get; set; } = null!;
    public int PositionId { get; set; }
    public Position Position { get; set; } = null!;
}
