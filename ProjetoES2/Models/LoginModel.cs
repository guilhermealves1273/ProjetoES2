using System.ComponentModel.DataAnnotations;

namespace ProjetoES2.Models;

public class LoginModel
{
    [EmailAddress]
    [Required(ErrorMessage = "Introduza o email")]
    public string Email { get; set; }
    [MinLength(6)]
    [Required(ErrorMessage = "Introduza a password")]
    public string Password { get; set; }
}
