namespace ProjetoES2.Models;
using ProjetoES2.Entities;

public class ProjetoViewModel


{
     public string Nome { get; set; }
     
     public string nomeCliente { get; set; }
     
     public double precoHora { get; set; }
     
     public ICollection<Tarefa> tarefas { get; set; }
     
     
     public ProjetoViewModel(Entities.Projeto projeto)
     {
          this.Nome = projeto.Nome;
          this.nomeCliente = projeto.NomeCliente;
          this.precoHora = projeto.PrecoHora;
          this.tarefas = projeto.Tarefas;

     }
}