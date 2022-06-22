using System;
using System.Collections.Generic;

namespace ProjetoES2.Entities
{
    public partial class Tarefa
    {
        public int IdTarefa { get; set; }
        public string Descricao { get; set; } = null!;
        public DateTime DataHoraInicio { get; set; }
        public DateTime DataHoraFim { get; set; }
        public double PrecoHora { get; set; }
        public int IdProjeto { get; set; }
        public int IdUser { get; set; }
        public string estado { get; set; }
/*
        public virtual Projeto? IdProjetoNavigation { get; set; }
        */
    }
}
