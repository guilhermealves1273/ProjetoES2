using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoES2.Entities
{
    [Table("Utilizador")]
    public partial class Utilizador
    {
        public Utilizador()
        {
            /* UtilizadorProjetos = new HashSet<UtilizadorProjeto>();*/

        }

        [Key] [Column("IdUser")] public int IdUser { get; set; }

        [Required(ErrorMessage = "Nome é de preenchimento obrigatório")]
        [Column("Nome")]
        [MinLength(2)]
        [MaxLength(100)]
        public string Nome { get; set; } = null!;


        [Required(ErrorMessage = "Email é de preenchimento obrigatório")]
        [EmailAddress(ErrorMessage = "Email inválido")]
        public string Email { get; set; } = null!;

        [Required(ErrorMessage = "Password é de preenchimento obrigatório")]
        [Column("Password")]
        [MinLength(6)]
        [MaxLength(100)]
        public string Password { get; set; } = null!;

        [Required(ErrorMessage = "Número de horas é de preenchimento obrigatório")]
        [Column("NumHorasDia")]
        public double NumHorasDia { get; set; }
        
        [Required(ErrorMessage = "Obrigatório selecionar um tipo de utilizador")]
        public string tipo { get; set; }

  /*
        public virtual ICollection<UtilizadorProjeto> UtilizadorProjetos { get; set; }
        */
    }
}
