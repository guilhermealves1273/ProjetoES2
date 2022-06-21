using Microsoft.EntityFrameworkCore;
using ProjetoES2.Context;
using ProjetoES2.Data;
using ProjetoES2.Entities;
using ProjetoES2.Models;


namespace ProjetoES2.Repositorio;

public class UtilizadorRepositorio : IUtilizadorRepositorio

{
    private readonly MyDbContext _context;
    

    public UtilizadorRepositorio(MyDbContext context)
    {
        _context = context;
    }

    public List<Utilizador> ListarUtilizadores()
    {
        return _context.Utilizadores.ToList();
    }

    public UtilizadorModel ListarPorNome(String nome)
    {
        return _context.Utilizadores.FirstOrDefault(x => x.nome.Equals(nome));
    }
    
    public UtilizadorModel Registar(UtilizadorModel utilizador)
    {
        _context.Utilizadores.Add(utilizador);
        _context.SaveChanges();
        return utilizador;
    }


}