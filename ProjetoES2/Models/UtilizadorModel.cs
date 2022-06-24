using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjetoES2.Models;

public class UtilizadorModel
{
    public UtilizadorModel(Entities.Utilizador utilizador)
    {
        this.nome = utilizador.Nome;
        this.email = utilizador.Email;
        this.password = utilizador.Password;
        this.numHorasDia = utilizador.NumHorasDia;
    }
    [Required(ErrorMessage = "Introduza o seu nome de utilizador")]
    public string nome { get; set; }
    
    [Required(ErrorMessage = "Introduza o seu email")]
    [EmailAddress(ErrorMessage = "O e-mail introduzido não é válido")]
    
    public string email { get; set; }
    
    [Required]
    [MinLength(3)]
    [MaxLength(10)]
    public string password  { get; set; }
    public double numHorasDia { get; set; }
    
    public string tipo { get; set; }
    
}
