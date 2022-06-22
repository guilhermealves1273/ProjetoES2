﻿using Microsoft.AspNetCore.Mvc;

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
        _Context.Remove(projeto);
        
        _Context.SaveChangesAsync();
        return RedirectToAction("Index");

    }
    
    public async Task<IActionResult> ListarTarefas(int id)
    {
        Console.WriteLine("idProjeto" + id);
        var tarefa1 = _Context.Tarefas.ToList().FindAll(x => x.IdProjeto == id);
        return View(tarefa1);

    }
    
    
}
    
