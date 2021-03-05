using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [EmailAddress(ErrorMessage ="Este endereço de email não é válido")]
        public string Email { get; set; }

        [Required(ErrorMessage ="O campo {0} é obrigatório")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }
    }
}
