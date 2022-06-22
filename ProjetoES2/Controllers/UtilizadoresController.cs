using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using ProjetoES2;

using ProjetoES2.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using ProjetoES2.Context;
using ProjetoES2.Entities;


namespace ProjetoES2.Controllers;

public class UtilizadoresController : Controller
{
    private readonly MyDbContext _Context;

    public UtilizadoresController()
    {
        _Context = new MyDbContext();
    }
    
    public IActionResult Index()
    {

        return View();
    }

    
    public IActionResult Criar()
    {
        
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Criar(Utilizador utilizador)
    {
        
            _Context.Add(utilizador);
            _Context.SaveChanges();
            return RedirectToAction("Index","Login");

    }
}