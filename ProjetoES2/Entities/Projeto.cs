using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoES2.Entities
{
    [Table("Projeto")]
    public partial class Projeto
    {
        public Projeto()
        {
        }
        
        [Key]
        [Column("idProjeto")]
        public int IdProjeto { get; set; }
        
        [Required(ErrorMessage = "Introduza nome do projeto")]
        [Column("nome")]
        public string Nome { get; set; } = null!;
        
        [Required(ErrorMessage = "Introduza nome de Cliente")]
        [Column("nomeCliente")]
        public string NomeCliente { get; set; } = null!;
        
        [Required(ErrorMessage = "Introduza um preço por hora")]
        [Column("precoHora")]
        public double PrecoHora { get; set; }
        
        [Column("idUser")]
        public int idUser { get; set; }
/*
        public virtual UtilizadorProjeto UtilizadorProjeto { get; set; } = null!;*/
   
    }
}