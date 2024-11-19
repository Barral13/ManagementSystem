using System.Text.Json.Serialization;

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

    public DateTime HiredAt { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime ActivatedAt { get; set; }
    public DateTime? ResignedAt { get; set; }

    [JsonIgnore]
    public Department Department { get; set; } = null!;
    public int DepartmentId { get; set; }

    [JsonIgnore]
    public Position Position { get; set; } = null!;
    public int PositionId { get; set; }
}
