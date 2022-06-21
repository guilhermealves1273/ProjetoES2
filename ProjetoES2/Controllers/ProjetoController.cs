using Microsoft.AspNetCore.Mvc;
using ProjetoES2.Context;
using ProjetoES2.Entities;

using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProjetoES2.Controllers;

public class ProjetoController : Controller
{
    // GET
    
    private readonly MyDbContext _Context;

    public ProjetoController()
    {
        _Context = new MyDbContext();
    }
    
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult criar()
    {
        return View();
    } 
    
    [HttpPost]
    
    public async void  criar(Projeto projeto)
    {
        
    }
    
}