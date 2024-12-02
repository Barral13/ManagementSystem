using ManagementSystem.Core.Entities;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Core.DTOs.PositionDto;

public class CreatePositionDto
{
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O Nome do cargo deve ter entre 3 e 100 caracteres.")]
    public string Name { get; set; } = string.Empty;

    [Required(ErrorMessage = "O campo DepartmentId é obrigatório.")]
    public int DepartmentId { get; set; }
}
