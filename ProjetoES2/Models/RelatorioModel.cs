using System.Collections;
using ProjetoES2.Entities;

namespace ProjetoES2.Models;

public class RelatorioModel 
{
     public RelatorioModel()
     {
          tarefas = new List<Tarefa>();
     }

     public List<Tarefa> tarefas { get; set; }
     
     public float HorasTotais { get; set; }
     
     public float PrecoTotal { get; set; }
     /*

     public int IdTarefa { get; set; }
        
     
     public string Descricao { get; set; } = null!;
        
        
     
     public DateTime DataInicio { get; set; }
    
     public DateTime? DataFim { get; set; }
        
    
     public double PrecoHora { get; set; }
        
    
     public int? IdProjeto { get; set; }
        
        
     
     public int IdUser { get; set; }
        
     
     public string estado { get; set; }
     
     public String HorasTotais { get; set; }
     
     public String PrecoTotal { get; set; }
     */
   
}