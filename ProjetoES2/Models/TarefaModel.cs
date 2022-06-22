using System.ComponentModel.DataAnnotations;

namespace ProjetoES2.Models;

public class TarefaModel
{

    public TarefaModel(Entities.Tarefa tarefa)
    {

        this.descricao = tarefa.Descricao;
        this.dataHora_inicio = tarefa.DataHoraInicio;
        this.dataHora_fim = tarefa.DataHoraFim;
        this.precoHora = tarefa.PrecoHora;
        this.idProjeto = tarefa.IdProjeto;
        this.Id_user = tarefa.IdUser;
        this.Estado = tarefa.estado;

    }
    
    
    [Required]
    public String descricao { get; set; }

    [Required]
    public DateTime dataHora_inicio { get; set; }

    [Required]
    public DateTime dataHora_fim{ get; set; }
   
    public double precoHora{ get; set; }
    
    public int idProjeto{ get; set; }
    
    public int Id_user{ get; set; }
    
    public string Estado{ get; set; }
}