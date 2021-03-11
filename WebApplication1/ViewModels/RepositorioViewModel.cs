using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class RepositorioViewModel
    {
        

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Utilizae menos caracteres")]
        public string Titulo { get; set; }

        
    }
}
