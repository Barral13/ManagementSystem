using ManagementSystem.Core.Enums;
using System.ComponentModel.DataAnnotations;

namespace ManagementSystem.Core.DTOs.EmployeeDto;

public class HireEmployeeDto
{
    [Required(ErrorMessage = "O primeiro nome é obrigatório.")]
    [StringLength(50, MinimumLength = 2, ErrorMessage = "O primeiro nome deve ter entre 2 e 50 caracteres.")]
    public string FirstName { get; set; } = string.Empty;

    [Required(ErrorMessage = "O sobrenome é obrigatório.")]
    [StringLength(80, MinimumLength = 2, ErrorMessage = "O sobrenome deve ter entre 2 e 50 caracteres.")]
    public string LastName { get; set; } = string.Empty;

    public EStatus Status { get; set; }

    [Required(ErrorMessage = "O email é obrigatório.")]
    [EmailAddress(ErrorMessage = "O email deve ser um endereço de email válido.")]
    public string Email { get; set; } = string.Empty;

    [Required(ErrorMessage = "O número de telefone é obrigatório.")]
    [RegularExpression(@"^\(?\d{2}\)?\s?\d{4,5}-\d{4}$", ErrorMessage = "Número de telefone inválido. O formato esperado é (XX) XXXX-XXXX ou (XX) XXXXX-XXXX.")]
    public string PhoneNumber { get; set; } = string.Empty;

    [Required(ErrorMessage = "O CPF é obrigatório.")]
    [RegularExpression(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$", ErrorMessage = "O CPF deve estar no formato 000.000.000-00.")]
    public string Cpf { get; set; } = string.Empty;
}
