using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ProjetoES2.Entities;

namespace ProjetoES2.Context
{
    public partial class MyDbContext : DbContext
    {
        public MyDbContext()
        {
        }

        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Projeto> Projetos { get; set; } = null!;
        public virtual DbSet<Tarefa> Tarefas { get; set; } = null!;
        public virtual DbSet<Utilizador> Utilizadores { get; set; } = null!;
        public virtual DbSet<UtilizadorProjeto> UtilizadorProjetos { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseNpgsql("Server=localhost;Database=es2;Port=5432;User Id=es2;Password=es2");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Projeto>(entity =>
            {
                entity.HasKey(e => e.IdProjeto)
                    .HasName("projeto_pk");

                entity.ToTable("Projeto");

                entity.Property(e => e.IdProjeto).HasColumnName("idProjeto");

                entity.Property(e => e.Nome)
                    .HasMaxLength(60)
                    .HasColumnName("nome");

                entity.Property(e => e.NomeCliente)
                    .HasMaxLength(100)
                    .HasColumnName("nomeCliente");

                entity.Property(e => e.PrecoHora).HasColumnName("precoHora");
            });

            modelBuilder.Entity<Tarefa>(entity =>
            {
                entity.HasKey(e => e.IdTarefa)
                    .HasName("tarefa_pk");

                entity.ToTable("Tarefa");

                entity.Property(e => e.IdTarefa).HasColumnName("idTarefa");

                entity.Property(e => e.DataHoraFim)
                    .HasColumnName("dataHora_fim")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.DataHoraInicio)
                    .HasColumnName("dataHora_inicio")
                    .HasDefaultValueSql("CURRENT_DATE");

                entity.Property(e => e.Descricao)
                    .HasMaxLength(150)
                    .HasColumnName("descricao");

                entity.Property(e => e.IdProjeto).HasColumnName("idProjeto");

                entity.Property(e => e.PrecoHora).HasColumnName("precoHora");

                entity.HasOne(d => d.IdProjetoNavigation)
                    .WithMany(p => p.Tarefas)
                    .HasForeignKey(d => d.IdProjeto)
                    .HasConstraintName("tarefa_projeto_idprojeto_fk");
            });

            modelBuilder.Entity<Utilizador>(entity =>
            {
                entity.HasKey(e => e.IdUser)
                    .HasName("utilizador_pk");

                entity.ToTable("Utilizador");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.Property(e => e.Email)
                    .HasMaxLength(100)
                    .HasColumnName("email");

                entity.Property(e => e.Nome)
                    .HasMaxLength(100)
                    .HasColumnName("nome");

                entity.Property(e => e.NumHorasDia).HasColumnName("numHorasDia");

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .HasColumnName("password");
            });

            modelBuilder.Entity<UtilizadorProjeto>(entity =>
            {
                entity.HasKey(e => e.IdProjeto)
                    .HasName("utilizador_projeto_pk");

                entity.ToTable("Utilizador_Projeto");

                entity.Property(e => e.IdProjeto)
                    .ValueGeneratedNever()
                    .HasColumnName("idProjeto");

                entity.Property(e => e.IdUser).HasColumnName("idUser");

                entity.HasOne(d => d.IdProjetoNavigation)
                    .WithOne(p => p.UtilizadorProjeto)
                    .HasForeignKey<UtilizadorProjeto>(d => d.IdProjeto)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("utilizador_projeto_projeto_idprojeto_fk");

                entity.HasOne(d => d.IdUserNavigation)
                    .WithMany(p => p.UtilizadorProjetos)
                    .HasForeignKey(d => d.IdUser)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("utilizador_projeto_utilizador_iduser_fk");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
