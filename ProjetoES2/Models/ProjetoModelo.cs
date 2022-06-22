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
    
    
    [Required]
    public String nome { get; set; }

    [Required]
    public String nomeCliente { get; set; }

    [Required]
    public double precoPorHora { get; set; }
   
    public int idUser { get; set; }
    

}