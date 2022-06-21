using System;
using System.Collections.Generic;

namespace ProjetoES2.Entities
{
    public partial class UtilizadorProjeto
    {
        public int IdUser { get; set; }
        public int IdProjeto { get; set; }
        public bool Convite { get; set; }

        public virtual Projeto IdProjetoNavigation { get; set; } = null!;
        public virtual Utilizador IdUserNavigation { get; set; } = null!;
    }
}
