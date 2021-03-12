using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.ViewModels;
using Microsoft.AspNetCore.Http;


namespace WebApplication1.Controllers
{
    public class RepositorioController : Controller
    {


        private readonly Contexto contexto;

        public RepositorioController(Contexto contexto)
        {


            this.contexto = contexto;
        }

        public async Task<IActionResult> TelaInicial(int usuarioId)
        {
           
            var repositorio = await contexto.Repositorios.ToListAsync();

            var repositorios = repositorio.Where(rep => rep.UsuarioId == usuarioId);

            ViewData["usuarioId"] = usuarioId;

            repositorios = repositorios.OrderBy(rep => rep.Titulo);

            return View(repositorios);
        }

        [HttpGet]
        public IActionResult AdicionarRepositorio(int usuarioId)
        {
            
            TempData["usuarioId"] = usuarioId;
            ViewData["usuarioid"] = usuarioId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AdicionarRepositorio(RepositorioViewModel model)
        {

            if (!ModelState.IsValid)
            {
                ModelState.AddModelError("", "Título é obrigatório");
                return View();
            }

            int usuarioId = Int32.Parse(TempData["usuarioId"].ToString());
            var usuario = await contexto.Usuarios.FindAsync(usuarioId);
            var repositorio = usuario.AdicionarRepositorio(model.Titulo, usuarioId);

            await contexto.Repositorios.AddAsync(repositorio);
            await contexto.SaveChangesAsync();
            return Redirect($"TelaInicial?usuarioId={usuarioId}");

        }

        [HttpPost]
        public async Task<JsonResult> ExcluirRepositorio(int repositorioId)
        {
            var repositorio = await contexto.Repositorios.FindAsync(repositorioId);
            var notas = await contexto.Notas.ToListAsync();
            var notasValidas = notas.Where(n => n.RepositorioId == repositorioId);

            if (notasValidas.Count() > 0)
            {
                TempData["RepositorioExcluido"] = $"Repositorio {repositorio.Titulo} não pode ser excluído pois possui {notasValidas.Count()} Notas armazenadas ";
                return Json(false);
            }
            contexto.Repositorios.Remove(repositorio);
            await contexto.SaveChangesAsync();
            return Json(true);
        }

        [HttpGet]
        public IActionResult EditarRepositorio(int repositorioId)
        {
            TempData["repositorioId"] = repositorioId;

            var repositorio = contexto.Repositorios.Find(repositorioId);

            ViewData["Titulo"] = repositorio.Titulo;
            ViewData["usuarioId"] = repositorio.UsuarioId;
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> EditarRepositorio(RepositorioViewModel model)
        {
           
                if (!ModelState.IsValid)
                {
                    ModelState.AddModelError("", "Título é obrigatório");
                    return View();
                }
            int repositorioId = Int32.Parse(TempData["repositorioId"].ToString());

            var repositorio = await contexto.Repositorios.FindAsync(repositorioId);

                repositorio.Titulo = model.Titulo;

                await contexto.SaveChangesAsync();

                return Redirect($"TelaInicial?usuarioId={repositorio.UsuarioId}");
        }

       
    }
}
