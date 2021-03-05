using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Nota
    {
        public int NotaId { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [StringLength(50,ErrorMessage ="Use menos caracteres")]
        public string Titulo { get; set; }

        [Required(ErrorMessage ="Não é possível criar uma anotação vazia")]
        public string Anotacao { get; set; }
        public int RepositorioId { get; set; }
        public Repositorio Repositorio { get; set; }

    }
}
