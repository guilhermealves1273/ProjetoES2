
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
      
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 1 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        var countTar= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 1 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador).Count;
        RelatorioModel model = new RelatorioModel();
        model.tarefas = tarefas;
        var PrecoTotal = 0;
        var HorasTotais = 0;
       
        foreach (var tarefa in tarefas)
        {
          
            var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
            PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
            HorasTotais = HorasTotais + horas;

        }

        model.HorasTotais=HorasTotais;
        model.PrecoTotal = PrecoTotal;
        return View(model);
    }
    
    
    public IActionResult Fevereiro()
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 2 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        var countTar= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 2 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador).Count;
        RelatorioModel model = new RelatorioModel();
        model.tarefas = tarefas;
        var PrecoTotal = 0;
        var HorasTotais = 0;
       
        foreach (var tarefa in tarefas)
        {
          
            var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
            PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
            HorasTotais = HorasTotais + horas;

        }

        model.HorasTotais=HorasTotais;
        model.PrecoTotal = PrecoTotal;
        return View(model);
    
    }
    
    public IActionResult Marco()
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 3 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        var countTar= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 3 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador).Count;
        RelatorioModel model = new RelatorioModel();
        model.tarefas = tarefas;
        var PrecoTotal = 0;
        var HorasTotais = 0;
       
        foreach (var tarefa in tarefas)
        {
          
            var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
            PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
            HorasTotais = HorasTotais + horas;

        }

        model.HorasTotais=HorasTotais;
        model.PrecoTotal = PrecoTotal;
        return View(model);
    }
    
    public IActionResult Abril()
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 4 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        var countTar= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 4 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador).Count;
        RelatorioModel model = new RelatorioModel();
        model.tarefas = tarefas;
        var PrecoTotal = 0;
        var HorasTotais = 0;
       
        foreach (var tarefa in tarefas)
        {
          
            var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
            PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
            HorasTotais = HorasTotais + horas;

        }

        model.HorasTotais=HorasTotais;
        model.PrecoTotal = PrecoTotal;
        return View(model);
    }
    
    public IActionResult Maio()
    {
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 5 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        var countTar= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 5 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador).Count;
        RelatorioModel model = new RelatorioModel();
        model.tarefas = tarefas;
        var PrecoTotal = 0;
        var HorasTotais = 0;
       
        foreach (var tarefa in tarefas)
        {
          
            var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
            PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
            HorasTotais = HorasTotais + horas;

        }

        model.HorasTotais=HorasTotais;
        model.PrecoTotal = PrecoTotal;
        return View(model);
    }
    
    public IActionResult Junho()
    {
        
      
       List<Tarefa> tarefas = new List<Tarefa>();
       tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 6 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
       var countTar= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 6 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador).Count;
       RelatorioModel model = new RelatorioModel();
       model.tarefas = tarefas;
       var PrecoTotal = 0;
       var HorasTotais = 0;
       
       foreach (var tarefa in tarefas)
       {
          
           var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
           PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
           HorasTotais = HorasTotais + horas;

       }

       model.HorasTotais=HorasTotais;
       model.PrecoTotal = PrecoTotal;
       return View(model);
    }
    
   public IActionResult Julho()
    {
        //var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 7 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 7 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
       
        RelatorioModel model = new RelatorioModel();
        model.tarefas = tarefas;
       
        var PrecoTotal = 0;
        var HorasTotais = 0;
       
        foreach (var tarefa in tarefas)
        {
          
            var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
            PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
            HorasTotais = HorasTotais + horas;

        }

        model.HorasTotais=HorasTotais;
        model.PrecoTotal = PrecoTotal;
        return View(model);
    }
    
    public IActionResult Agosto()
    {
       //var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 8 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
       List<Tarefa> tarefas = new List<Tarefa>();
       tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 8 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
       
       RelatorioModel model = new RelatorioModel();
       model.tarefas = tarefas;
       
       var PrecoTotal = 0;
       var HorasTotais = 0;
       
       foreach (var tarefa in tarefas)
       {
          
           var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
           PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
           HorasTotais = HorasTotais + horas;

       }

       model.HorasTotais=HorasTotais;
       model.PrecoTotal = PrecoTotal;
       return View(model);
    }
    
    public IActionResult Setembro()
    {
        //var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 9 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 9 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
       
        RelatorioModel model = new RelatorioModel();
        model.tarefas = tarefas;
       
        var PrecoTotal = 0;
        var HorasTotais = 0;
       
        foreach (var tarefa in tarefas)
        {
          
            var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
            PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
            HorasTotais = HorasTotais + horas;

        }

        model.HorasTotais=HorasTotais;
        model.PrecoTotal = PrecoTotal;
        return View(model);
    }
    
    public IActionResult Outubro()
    {
        //var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 10 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 10 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
       
        RelatorioModel model = new RelatorioModel();
        model.tarefas = tarefas;
        
        var PrecoTotal = 0;
        var HorasTotais = 0;
       
        foreach (var tarefa in tarefas)
        {
          
            var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
            PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
            HorasTotais = HorasTotais + horas;

        }

        model.HorasTotais=HorasTotais;
        model.PrecoTotal = PrecoTotal;
        return View(model);
    }
    
    public IActionResult Novembro()
    {
        //var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 11 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 11 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
       
        RelatorioModel model = new RelatorioModel();
        model.tarefas = tarefas;
        var PrecoTotal = 0;
        var HorasTotais = 0;
       
        foreach (var tarefa in tarefas)
        {
          
            var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
            PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
            HorasTotais = HorasTotais + horas;

        }

        model.HorasTotais=HorasTotais;
        model.PrecoTotal = PrecoTotal;
        return View(model);
    }
    
    public IActionResult Dezembro()
    {
        //var tarefas = _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 12 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        List<Tarefa> tarefas = new List<Tarefa>();
        tarefas= _Context.Tarefas.ToList().FindAll(x => x.DataInicio.Month == 12 && x.estado.Equals("Terminada") && x.IdUser==UserSession.idUtilizador);
        
        RelatorioModel model = new RelatorioModel();
        model.tarefas = tarefas;
        var PrecoTotal = 0;
        var HorasTotais = 0;
       
        foreach (var tarefa in tarefas)
        {
          
            var horas = tarefa.DataFim.Value.TimeOfDay.Hours - tarefa.DataInicio.TimeOfDay.Hours;
            PrecoTotal = (int)(PrecoTotal + (horas * tarefa.PrecoHora));
            HorasTotais = HorasTotais + horas;

        }

        model.HorasTotais=HorasTotais;
        model.PrecoTotal = PrecoTotal;
        return View(model);
    }
    

}