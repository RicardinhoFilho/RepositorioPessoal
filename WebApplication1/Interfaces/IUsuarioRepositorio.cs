using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Interfaces
{
    public interface IUsuarioRepositorio : IRepositorioGenerico<Usuario>
    {
        Task LogarUsuario(Usuario usuario, bool lembrar);
        Task<IdentityResult> CriarUsuario(Usuario usuario, string senha);
    }
}
