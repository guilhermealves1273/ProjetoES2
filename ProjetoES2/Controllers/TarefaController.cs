using Microsoft.AspNetCore.Mvc;
using NuGet.Packaging.Signing;
using ProjetoES2.Context;
using ProjetoES2.Entities;

namespace ProjetoES2.Controllers;

public class TarefaController : Controller
{
    
    private readonly MyDbContext _Context;
    
    
    public TarefaController()
    {
        _Context = new MyDbContext();
    }
    // GET
    public IActionResult Index()
    {
        var tarefa = _Context.Tarefas.ToList().FindAll(x => x.IdUser == UserSession.idUtilizador);
        return View(tarefa);
    }
    
    public async Task<IActionResult> criar()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> criar(Tarefa tarefa)
    {
        tarefa.IdUser = UserSession.idUtilizador;
        tarefa.estado = "Em curso";
        tarefa.DataInicio = DateTime.Now;
        tarefa.IdProjeto = 0;
        
        Console.WriteLine(tarefa.Descricao);
        Console.WriteLine(tarefa.PrecoHora);
        Console.WriteLine(tarefa.IdUser);
        Console.WriteLine(tarefa.estado);
        Console.WriteLine(tarefa.DataInicio);
        Console.WriteLine(tarefa.DataFim);
        Console.WriteLine(tarefa.IdProjeto);
        
        
        _Context.Add(tarefa); 
        await _Context.SaveChangesAsync();
        return RedirectToAction("Index", "Tarefa");
    }
}