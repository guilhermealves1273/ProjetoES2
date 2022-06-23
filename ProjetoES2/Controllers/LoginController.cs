using System.Diagnostics.CodeAnalysis;
using ProjetoES2;
using Microsoft.AspNetCore.Mvc;
using ProjetoES2.Context;
using ProjetoES2.Models;


namespace ProjetoES2.Controllers;

public class LoginController : Controller
{
    // GET
    private readonly MyDbContext _context;

    public LoginController()
    {
        _context = new MyDbContext();
    }
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(LoginModel login)
    {
        Console.WriteLine(1);
        var user = _context.Utilizadores
                .FirstOrDefault(u => u.Email.Equals(login.Email) && u.Password.Equals(login.Password));
            
               
            if (user != null)
            {
                UserSession.idUtilizador  = user.IdUser;
                UserSession.nome= user.Nome;
                Console.WriteLine(UserSession.nome);
                Console.WriteLine(UserSession.idUtilizador);
                
                return RedirectToAction("Index","Home");
            }

            ViewData["HasError"] = true;

            return RedirectToAction("Index","Login");
        }
    
    [HttpPost]
    public async Task<IActionResult> Logout(Index index)
    {
        
        return RedirectToAction("Index", index);
    }



}