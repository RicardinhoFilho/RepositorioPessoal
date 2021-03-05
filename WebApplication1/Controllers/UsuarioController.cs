
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;
using WebApplication1.Models;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly Contexto contexto;
        private readonly IWebHostEnvironment _webHostEnvironment;


        public UsuarioController(Contexto contexto, IWebHostEnvironment webHostEnvironment)
        {
            this.contexto = contexto;
            _webHostEnvironment = webHostEnvironment;
        }

        [HttpGet]
        public IActionResult NovoUsuario()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> NovoUsuario(RegistroViewModel model, IFormFile foto)
        {
            if (ModelState.IsValid)
            {
                if (foto != null)
                {
                    string diretorioPasta = Path.Combine(_webHostEnvironment.WebRootPath, "img");
                    string nomeFoto = Guid.NewGuid().ToString() + foto.FileName;

                    using (FileStream fileStream = new FileStream(Path.Combine(diretorioPasta, nomeFoto), FileMode.Create))
                    {
                        await foto.CopyToAsync(fileStream);
                        model.Foto = "~/img" + nomeFoto;
                    }
                }
                else
                {
                    model.Foto = "~/img/ImagemPadrao.png";
                }


                Usuario usuario = new Usuario();
                //IdentityResult usuarioCriado;

                usuario.Nome = model.Nome;
                usuario.Email = model.Email;
                usuario.Foto = model.Foto;
                usuario.Senha = model.Senha;

                contexto.Add(usuario);
                await contexto.SaveChangesAsync();
            }
            return View(model);
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {

               
                if (contexto.Usuarios.Where(e => e.Email == model.Email) != null)
                {
                    int  usuarioid = 0;
                    var usuarios = await contexto.Usuarios.ToListAsync();
                    foreach (var usuarioo in usuarios)
                    {
                        if (usuarioo.Email == model.Email)
                        {
                            usuarioid = usuarioo.UsuarioId;
                            break;
                        }
                    }

                    var usuario = await contexto.Usuarios.FindAsync(usuarioid);

                    if (usuario.Senha == model.Senha)
                    {
                        
                        //var Repositorios = await contexto.Repositorios.ToListAsync();
                        //foreach (var item in Repositorios)
                        //{

                        //}

                        
                        return View("Inicio");
                    }
                    else
                    {
                        ModelState.AddModelError("", "Senha inválida");
                        return View(model);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Email inválido");
                    return View(model);
                }



            }
            else
            {
                return View(model);
            }
        }

    }
}
