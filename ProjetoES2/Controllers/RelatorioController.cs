
using Microsoft.AspNetCore.Mvc;
using ProjetoES2.Context;
using ProjetoES2.Entities;
using ProjetoES2.Models;

namespace ProjetoES2.Controllers;

public class RelatorioController : Controller
{
    // GET
    
    private readonly MyDbContext _Context;

    public RelatorioController()
    {
        _Context = new MyDbContext();
    }
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult Janeiro()
    {
       var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 1 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        return View(tarefas);
    }
    
    public IActionResult Fevereiro()
    {
        var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 2 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        return View();
    }
    
    public IActionResult Marco()
    {
        var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 3 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        return View();
    }
    
    public IActionResult Abril()
    {
        var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 4 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        return View();
    }
    
    public IActionResult Maio()
    {
        var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 5 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        return View();
    }
    
    public IActionResult Junho()
    {
        
       // var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 6 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
       List<Tarefa> tarefas = new List<Tarefa>();
       tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 6 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
       
       RelatorioModel model = new RelatorioModel();
       model.tarefas = tarefas;
       
       

       model.HorasTotais =1;
       model.PrecoTotal = 2;
       return View(model);
    }
    
    public IActionResult Julho()
    {
        var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 7 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        return View();
    }
    
    public IActionResult Agosto()
    {
        var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 8 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        return View();
    }
    
    public IActionResult Setembro()
    {
        var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 9 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        return View();
    }
    
    public IActionResult Outubro()
    {
        var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 10 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        return View();
    }
    
    public IActionResult Novembro()
    {
        var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 11 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        return View();
    }
    
    public IActionResult Dezembro()
    {
        var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 12 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        return View();
    }
    

}