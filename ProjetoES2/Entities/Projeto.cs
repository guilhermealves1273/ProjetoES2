using System;
using System.Collections.Generic;

namespace ProjetoES2.Entities
{
    public partial class Projeto
    {
        public Projeto()
        {
            Tarefas = new HashSet<Tarefa>();
        }

        public int IdProjeto { get; set; }
        public string Nome { get; set; } = null!;
        public string NomeCliente { get; set; } = null!;
        public double PrecoHora { get; set; }

        public virtual UtilizadorProjeto UtilizadorProjeto { get; set; } = null!;
        public virtual ICollection<Tarefa> Tarefas { get; set; }
    }
}
