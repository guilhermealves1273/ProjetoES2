using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using MessagePack;
using Microsoft.Build.Framework;

namespace ProjetoES2.Entities
{
    [Table("Tarefa")]
    public partial class Tarefa
    {
        public Tarefa(){}
        
 
        [Column("idTarefa")]
        public int IdTarefa { get; set; }
        
        
        [Column("descricao")]
        public string Descricao { get; set; } = null!;
        
        
        [Column("dataInicio")]
        public DateTime DataInicio { get; set; }
        
        [Column("dataFim")]
        public DateTime DataFim { get; set; }
        
       
        [Column("precoHora")]
        public double PrecoHora { get; set; }
        
        [Column("idProjeto")]
        public int IdProjeto { get; set; }
        
        
        [Column("Id_user")]
        public int IdUser { get; set; }
        
        [Column("Estado")]
        public string estado { get; set; }
/*
        public virtual Projeto? IdProjetoNavigation { get; set; }
        */
    }
}
