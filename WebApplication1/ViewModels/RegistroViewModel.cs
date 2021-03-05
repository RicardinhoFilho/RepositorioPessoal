using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.ViewModels
{
    public class RegistroViewModel
    {

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(50,ErrorMessage = "Use Menos Caracteres")]
        public string Nome { get; set; }

        public string Foto { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Use Menos Caracteres")]
        [EmailAddress(ErrorMessage ="Email inválido")]
        public string Email { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Use Menos Caracteres")]
        [DataType(DataType.Password)]
        public string Senha { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        [StringLength(40, ErrorMessage = "Use Menos Caracteres")]
        [DataType(DataType.Password)]
        [Display(Name ="Confirme sua senha")]
        [Compare("Senha", ErrorMessage ="As senhas não conferem")]
        public string SenhaConfirmada { get; set; }
    }
}
