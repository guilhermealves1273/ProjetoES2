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
            UtilizadorProjetos = new HashSet<UtilizadorProjeto>();
            
        }

        [Key]
        [Column("IdUser")]
        public int IdUser { get; set; }
        
        [Required]
        [Column("Nome")]
        [StringLength(100)]
        public string Nome { get; set; } = null!;
        
        [Required]
        [Column("Email")]
        [StringLength(100)]
        public string Email { get; set; } = null!;
        
        [Required]
        [Column("Password")]
        [StringLength(100)]
        public string Password { get; set; } = null!;
        
        [Required]
        [Column("NumHorasDia")]
        public double NumHorasDia { get; set; }

        public virtual ICollection<UtilizadorProjeto> UtilizadorProjetos { get; set; }
    }
}
