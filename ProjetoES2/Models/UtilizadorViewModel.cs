namespace ProjetoES2.Models;

public class UtilizadorViewModel
{
    
    
    public int IdUser { get; set; }
    public string Nome { get; set; } = null!;
    public string Email { get; set; } = null!;

    public UtilizadorViewModel(Entities.Utilizador utilizador)
    {
        this.IdUser = utilizador.IdUser;
        this.Nome = utilizador.Nome;
        this.Email = utilizador.Email;
    }
   
}