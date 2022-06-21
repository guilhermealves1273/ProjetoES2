using ProjetoES2.Entities;

namespace ProjetoES2.Models;

public class TarefasViewModel
{
    public string Descricao { get; set; } = null!;
    public DateOnly DataHoraInicio { get; set; }
    public DateOnly? DataHoraFim { get; set; }
    public double? PrecoHora { get; set; }
    public int? IdProjeto { get; set; }

    public TarefasViewModel(Entities.Tarefa tarefa)
    {

        this.Descricao = tarefa.Descricao;
        this.DataHoraInicio = tarefa.DataHoraInicio;
        this.DataHoraFim = tarefa.DataHoraFim;
        this.PrecoHora = tarefa.PrecoHora;
        this.IdProjeto = tarefa.IdProjeto;
    }
    
    
}