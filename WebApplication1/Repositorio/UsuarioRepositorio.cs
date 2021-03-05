using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Interfaces;
using WebApplication1.Models;

namespace WebApplication1.Repositorio
{
    public class UsuarioRepositorio : RepositorioGenerico<Usuario>, IUsuarioRepositorio
    {
        private readonly Contexto contexto;
        private readonly UserManager<Usuario> gerenciarUsuarios;
        private readonly SignInManager<Usuario> gerenciarLogin;

        public UsuarioRepositorio(Contexto contexto, UserManager<Usuario> gerenciadorUsuarios, SignInManager<Usuario> gerenciadorLogin) : base(contexto)
        {
            this.contexto = contexto;
            this.gerenciarUsuarios = gerenciadorUsuarios;
            this.gerenciarLogin = gerenciadorLogin;
        }

        public async Task<IdentityResult> CriarUsuario(Usuario usuario, string senha)
        {
            try
            {
                return await gerenciarUsuarios.CreateAsync(usuario, senha);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public async Task LogarUsuario(Usuario usuario, bool lembrar)
        {
            try
            {
                 await gerenciarLogin.SignInAsync(usuario, lembrar);
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
