using Microsoft.AspNetCore.Mvc;
using ProjetoES2.Context;
using ProjetoES2.Entities;

namespace ProjetoES2.Controllers;

public class AdminController : Controller
{
    private readonly MyDbContext _context;

    public AdminController()
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
        util.Email = utilizador.Email;
        util.tipo = utilizador.tipo;

        _context.Utilizadores.Update(util);
        await _context.SaveChangesAsync();
        return RedirectToAction("ListarUtilizadores");
    }

    public async Task<IActionResult> ApagarUtilizador(int id)
    {
        var utilizador = _context.Utilizadores.FirstOrDefault(m => m.IdUser == id);
        return View(utilizador);
    }

    [HttpPost]
    [ActionName("ApagarUtilizador")]
    public async Task<IActionResult> Apagar(int id)
    {
        Console.WriteLine(id);
        var utilizador = _context.Utilizadores.Find(id);

        Console.WriteLine(utilizador.Nome);
        
        if (utilizador.tipo.Equals("user"))
        {
            
            _context.Utilizadores.Remove(utilizador);
            _context.SaveChanges();


            var tarefas = _context.Tarefas.ToList().FindAll(x => x.IdUser == id).Count;

            Console.Write("numeroTarefas:" + tarefas + "\n");

            for (int i = 0; i < tarefas; i++)
            {
                var tarefa = _context.Tarefas.First(x => x.IdUser == id);
                _context.Tarefas.Remove(tarefa);
                _context.SaveChanges();
            }

            var projetos = _context.Projetos.ToList().FindAll(x => x.idUser == id).Count;

            Console.Write("numeroProjetos:" + projetos + "\n");

            for (int i = 0; i < projetos; i++)
            {
                var projeto = _context.Projetos.First(x => x.idUser == id);
                _context.Projetos.Remove(projeto);
                _context.SaveChanges();

            }
        }
        else
        {
            return RedirectToAction("ListarUtilizadores");
        }
        
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
        _context.Add(utilizador);
        await _context.SaveChangesAsync();
        return RedirectToAction("ListarUtilizadores");
    }

}