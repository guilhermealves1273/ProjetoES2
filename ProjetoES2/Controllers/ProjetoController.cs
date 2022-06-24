using Microsoft.AspNetCore.Mvc;

using ProjetoES2.Entities;

using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjetoES2.Context;
using ProjetoES2.Models;

namespace ProjetoES2.Controllers;

public class ProjetoController : Controller
{
    // GET

    private readonly MyDbContext _Context;

    public ProjetoController()
    {
        _Context = new MyDbContext();
    }

    public async Task<IActionResult> Index()
    {
        var projeto = _Context.Projetos.ToList().FindAll(x => x.idUser == UserSession.idUtilizador);
        return View(projeto);
    }

    public async Task<IActionResult> criar()
    {
        
        return View();
       
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> criar(Projeto projeto)
    {
        projeto.idUser = UserSession.idUtilizador;
        
        Console.WriteLine(projeto.idUser);
        Console.WriteLine(projeto.Nome);
        Console.WriteLine(projeto.NomeCliente);
        Console.WriteLine(projeto.PrecoHora);


        _Context.Projetos.Add(projeto); 
        await _Context.SaveChangesAsync();
        return RedirectToAction("Index");

    }
    
    public async Task<IActionResult> editar(int id)
    {
        var projeto = await _Context.Projetos.FindAsync(id);
        return View(projeto);
       
    }
    [HttpPost]
    public async Task<IActionResult> editar(Projeto projeto)
    {
        projeto.idUser = UserSession.idUtilizador;
        _Context.Update(projeto);
        await _Context.SaveChangesAsync();
        return View(projeto);
    }
    
    public async Task<IActionResult> delete(int id)
    {
       

        var projeto = await _Context.Projetos.FirstOrDefaultAsync(m => m.IdProjeto == id);
        return View(projeto);
    }

    [HttpPost]
    [ActionName("delete")]
    public async Task<IActionResult> deleteConfirmacao(int id)
    {
        var projeto = _Context.Projetos.Find(id);
        _Context.Projetos.Remove(projeto);
      
            
        var tarefas = _Context.Tarefas.ToList().FindAll(x => x.IdProjeto == id).Count;
         
        Console.Write("numeroTarefas:"+tarefas+"\n");
        
        for (int i = 0; i < tarefas; i++)
        {
           var tarefa = _Context.Tarefas.First(x => x.IdProjeto == id);
            _Context.Tarefas.Remove(tarefa);
            _Context.SaveChanges();

        }
        
        await _Context.SaveChangesAsync();
        return RedirectToAction("Index");

    }
    
    public async Task<IActionResult> ListarTarefas(int id)
    {
        Console.WriteLine("idProjeto" + id);
        UserSession.idProjeto = id;
        var tarefa1 = _Context.Tarefas.ToList().FindAll(x => x.IdProjeto == id);
        return View(tarefa1);

    }
    public async Task<IActionResult> DesassociarTarefa(int id)
    {
       
        var tarefa = await _Context.Tarefas.FirstOrDefaultAsync(m => m.IdTarefa == id);
        

        return View(tarefa);
    }
[HttpPost]
[ActionName("DesassociarTarefa")]
    public async Task<IActionResult> Desassociar(int id)
    {
        var tarefa = _Context.Tarefas.Find(id);
        Console.Write("numeroTarefas:"+tarefa.IdTarefa+"\n");
        tarefa.IdProjeto = null;
        _Context.Tarefas.Update(tarefa);
        await _Context.SaveChangesAsync();
        return RedirectToAction("ListarTarefas");
    }

    public async Task<IActionResult> AdicionarTarefa()
    {
        var tarefas = _Context.Tarefas.ToList()
            .FindAll(x => x.IdProjeto == null && x.IdUser == UserSession.idUtilizador);
        return View(tarefas);
    }


    public async Task<IActionResult> ConfirmacaoAssociacao(int id)
    {
        var tarefa = _Context.Tarefas.Find(id);
        return View(tarefa);
    }
    [HttpPost]
    [ActionName("ConfirmacaoAssociacao")]
    public async Task<IActionResult> Confirmacao(int idTarefa)
    {
        Console.WriteLine("adicionar:"+ idTarefa);
        var tarefa = _Context.Tarefas.Find(idTarefa);
        var projeto = _Context.Projetos.Find(UserSession.idProjeto);

        
            tarefa.IdProjeto = UserSession.idProjeto;
            tarefa.PrecoHora = projeto!.PrecoHora;
            _Context.Tarefas.Update(tarefa);
            await _Context.SaveChangesAsync();
            return RedirectToAction("Index");



    }

}
    
