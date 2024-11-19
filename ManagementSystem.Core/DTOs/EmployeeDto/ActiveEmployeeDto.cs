using System.ComponentModel.DataAnnotations;
using ManagementSystem.Core.Entities;

namespace ManagementSystem.Core.DTOs.EmployeeDto;

public class ActiveEmployeeDto
{
    [Required(ErrorMessage = "O campo DepartmentId é obrigatório.")]
    public int DepartmentId { get; set; }

    [Required(ErrorMessage = "O campo PositionId é obrigatório.")]
    public int PositionId { get; set; }

    [Range(0, double.MaxValue, ErrorMessage = "O salário deve ser um valor positivo.")]
    public decimal Salary { get; set; }

    [DataType(DataType.Date)]
    public DateTime ActivatedAt { get; set; } = DateTime.Now;
}
