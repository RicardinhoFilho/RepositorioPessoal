using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Repositorio
    {
        public int RepositorioId { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage ="Utilizae menos caracteres")]
        public string Titulo { get; set; }
        public int UsuarioId { get; set; }

        public Usuario Usuario { get; set; }


        public Nota AdicionarNota(string titulo, string anotacao)
        {
            Nota nota = new Nota();
            nota.RepositorioId = RepositorioId;
            nota.Titulo = titulo;
            nota.Anotacao = anotacao;

            return nota;
        }
    }
}
