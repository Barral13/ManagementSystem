using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Core.DTOs.EmployeeDto;

public class UpdateEmployeeDto
{
    [StringLength(50, MinimumLength = 2, ErrorMessage = "O primeiro nome deve ter entre 2 e 50 caracteres.")]
    public string? FirstName { get; set; }

    [StringLength(80, MinimumLength = 2, ErrorMessage = "O sobrenome deve ter entre 2 e 50 caracteres.")]
    public string? LastName { get; set; }

    [EmailAddress(ErrorMessage = "O email deve ser um endereço de email válido.")]
    public string? Email { get; set; }

    [Phone(ErrorMessage = "O número de telefone deve ser válido.")]
    public string? PhoneNumber { get; set; }

    [Range(0.01, double.MaxValue, ErrorMessage = "O salário deve ser um valor positivo com até duas casas decimais.")]
    [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
    public decimal? Salary { get; set; }

    public int? DepartmentId { get; set; }
    public int? PositionId { get; set; }

    [DataType(DataType.Date)]
    public DateTime UpdatedAt { get; set; } = DateTime.Now;
}
