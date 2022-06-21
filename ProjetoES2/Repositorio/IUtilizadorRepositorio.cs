using ProjetoES2.Entities;
using ProjetoES2.Models;

namespace ProjetoES2.Repositorio;

public interface IUtilizadorRepositorio
{
    List<Utilizador> ListarUtilizadores();

    UtilizadorModel ListarPorNome(string nome);

    UtilizadorModel Registar(UtilizadorModel utilizadorModel);


}