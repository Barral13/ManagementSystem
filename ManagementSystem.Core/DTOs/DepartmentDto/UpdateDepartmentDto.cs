using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Core.DTOs.DepartmentDto;

public class UpdateDepartmentDto
{
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O Nome do departamento deve ter entre 3 e 100 caracteres.")]
    public string Name { get; set; } = string.Empty;
}
