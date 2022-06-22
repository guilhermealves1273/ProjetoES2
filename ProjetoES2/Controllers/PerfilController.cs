using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjetoES2.Context;
using ProjetoES2.Entities;

namespace ProjetoES2.Controllers;

public class PerfilController : Controller
{
    // GET
    private readonly MyDbContext _context;

    public PerfilController()
    {
        _context = new MyDbContext();
    }
    
    
    public async Task<ActionResult> Index()
    {
        var utilizador = _context.Utilizadores.FirstOrDefault(x => x.IdUser == UserSession.idUtilizador);
        return View(utilizador);
    }

    public IActionResult Editar()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Editar(Utilizador utilizador)
    {
        var util = _context.Utilizadores.FirstOrDefault(x => x.IdUser == UserSession.idUtilizador);
        util.Nome = utilizador.Nome;
        util.Email = utilizador.Email;
        util.Password = utilizador.Password;
        util.NumHorasDia = utilizador.NumHorasDia;

        _context.Update(util);
        _context.SaveChanges();
        return RedirectToAction("Index");
    }

}