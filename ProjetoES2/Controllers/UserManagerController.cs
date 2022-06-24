using Microsoft.AspNetCore.Mvc;
using ProjetoES2.Context;
using ProjetoES2.Entities;

namespace ProjetoES2.Controllers;

public class UserManagerController : Controller
{
    private readonly MyDbContext _context;

    public UserManagerController()
    {
        _context = new MyDbContext();
    }

    public IActionResult Index()
    {
        return View();
    }

    public async Task<IActionResult> ListarProjetos()
    {
        var projetos = _context.Projetos.ToList();
        return View(projetos);
    }

    public async Task<IActionResult> ListarTarefas()
    {
        var tarefas = _context.Tarefas.ToList();
        return View(tarefas);
    }

    public async Task<IActionResult> ListarUtilizadores()
    {
        var utilizadores = _context.Utilizadores.ToList();
        return View(utilizadores);
    }

    public async Task<IActionResult> EditarUtilizador(int id)
    {
        var utilizador = _context.Utilizadores.FirstOrDefault(x => x.IdUser == id);
        return View(utilizador);
    }

    [HttpPost]
    public async Task<IActionResult> EditarUtilizador(int id, Utilizador utilizador)
    {
        var util = _context.Utilizadores.FirstOrDefault(x => x.IdUser == id);

        util.Nome = utilizador.Nome;
        util.NumHorasDia = utilizador.NumHorasDia;
        util.Email = utilizador.Email;
        
        _context.Utilizadores.Update(util);
        await _context.SaveChangesAsync();
        return RedirectToAction("ListarUtilizadores");
    }
    
    public async Task<IActionResult> criarUtilizador()
    {
        return View();
    }
    
    [HttpPost]
    public async Task<IActionResult> criarUtilizador(Utilizador utilizador)
    {
        _context.Utilizadores.Add(utilizador);
        await _context.SaveChangesAsync();
        return RedirectToAction("ListarUtilizadores");
    }

}