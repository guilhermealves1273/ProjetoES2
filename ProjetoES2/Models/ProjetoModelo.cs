using System.ComponentModel.DataAnnotations;

namespace ProjetoES2.Models;

public class ProjetoModelo
{

    public ProjetoModelo(Entities.Projeto projeto)
    {

        this.nome = projeto.Nome;
        this.nomeCliente = projeto.NomeCliente;
        this.precoPorHora = projeto.PrecoHora;
    }
    
    
    [Required(ErrorMessage = "Introduza nome do projeto")]
    public String nome { get; set; }

    [Required(ErrorMessage = "Introduza nome de Cliente")]
    public String nomeCliente { get; set; }

    [Required(ErrorMessage = "Introduza um preço por hora")]
    public double precoPorHora { get; set; }
   
    public int idUser { get; set; }
    

}