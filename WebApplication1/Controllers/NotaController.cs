using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class NotaController : Controller
    {
        public Contexto contexto;
        public NotaController(Contexto contexto)
        {
            this.contexto = contexto;
        }

        public async Task<IActionResult> ExibirNotas(string repositorioId)
        {
            int repId = Int32.Parse(repositorioId);
            var notasGerais = await contexto.Notas.ToListAsync();

            var notas = notasGerais.Where(n => n.RepositorioId == repId);

            ViewData["repositorioId"] = repositorioId;

            return View(notas);
        }

        [HttpGet]
        public IActionResult AdicionarNota(int codigo)
        {
            TempData["repositorioId"] = codigo;
            ViewData["repositorioId"] = codigo;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarNota(NotaViewModel model)//AdicionaarNota lembrarr
        {
            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Anotação é inválida");
                return View();
            }

            int repositorioId = Int32.Parse(TempData["repositorioId"].ToString());

            var repositorio = await contexto.Repositorios.FindAsync(repositorioId);
           

            var nota = repositorio.AdicionarNota(model.Titulo, model.Anotacao);

            
            await contexto.Notas.AddAsync(nota);
            await contexto.SaveChangesAsync();

            
            return Redirect($"ExibirNotas?repositorioId={repositorioId}");
        }


        public async Task<IActionResult> ExibirDetalhes(int id)
        {
            try
            {
                var nota = await contexto.Notas.FindAsync(id);

                return View(nota);

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task<IActionResult> ExcluirNota(int notaId)
        {
            var nota = await contexto.Notas.FindAsync(notaId);

            int repositorioId = nota.RepositorioId;

            contexto.Notas.Remove(nota);
            await contexto.SaveChangesAsync();

            return Redirect($"ExibirNotas?repositorioId={repositorioId}");

        }

        [HttpGet]
        public IActionResult EditarNota(int notaId)
        {
            TempData["notaId"] = notaId;
            
            var nota =  contexto.Notas.Find(notaId);

            ViewData["Titulo"] = nota.Titulo;
            ViewData["Anotacao"] = nota.Anotacao;
            ViewData["repositorioId"] = nota.RepositorioId;

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditarNota(NotaViewModel model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            int notaId = Int32.Parse(TempData["notaId"].ToString());

            var nota = await contexto.Notas.FindAsync(notaId);

            nota.Titulo = model.Titulo;
            nota.Anotacao = model.Anotacao;

            await contexto.SaveChangesAsync();

            return Redirect($"ExibirNotas?repositorioId={nota.RepositorioId}");

        }

    }
}
