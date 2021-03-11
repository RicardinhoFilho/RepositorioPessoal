using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Usuario
    {
        public int UsuarioId { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(30, ErrorMessage = "Use menos caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage = "Escreva um Email válido")]
        public string Email { get; set; }
        public string Foto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        public Repositorio AdicionarRepositorio(string titulo, int chave)
        {
            Repositorio repositorio = new Repositorio();
            repositorio.Titulo = titulo;
            repositorio.UsuarioId = chave;

            return repositorio;
        }

       
       

    }
}
