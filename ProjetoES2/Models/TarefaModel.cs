using System.ComponentModel.DataAnnotations;
using NuGet.Packaging.Signing;

namespace ProjetoES2.Models;

public class TarefaModel
{

    public TarefaModel(Entities.Tarefa tarefa)
    {

        this.descricao = tarefa.Descricao;
        this.dataInicio = tarefa.DataInicio;
        this.dataFim = tarefa.DataFim;
        this.precoHora = tarefa.PrecoHora;
        this.idProjeto = (int)tarefa.IdProjeto;
        this.Id_user = tarefa.IdUser;
        this.Estado = tarefa.estado;
       

    }
    [Required(ErrorMessage = "Introduza uma descrição para a tarefa")]
    public String descricao { get; set; }

    [Required]
    public DateTime dataInicio { get; set; }

    [Required]
    public DateTime? dataFim{ get; set; }
    
    [Required(ErrorMessage = "Introduza o preço por hora da tarefa")]
    public double precoHora{ get; set; }
    
    public int idProjeto{ get; set; }
    
    public int Id_user{ get; set; }
    
    public string Estado{ get; set; }
}