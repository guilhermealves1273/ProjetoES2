using System;
using System.Collections.Generic;

namespace ProjetoES2.Entities
{
    public partial class Tarefa
    {
        public int IdTarefa { get; set; }
        public string Descricao { get; set; } = null!;
        public DateOnly DataHoraInicio { get; set; }
        public DateOnly? DataHoraFim { get; set; }
        public double? PrecoHora { get; set; }
        public int? IdProjeto { get; set; }

        public virtual Projeto? IdProjetoNavigation { get; set; }
    }
}
