using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ValidacaoCustomizada
{
    public class Usuario
    {
        [Required(ErrorMessage = "O campo nome é de preenchimento obritaagorio")]
        public string Nome { get; set; }

        [Required,MinhaValidacao(ErrorMessage = "O campo senha deve possuir 10 caracteres")]

        public string Senha { get; set; }

        [Required, EmailAddress]
        public string Email { get; set; }
    }
}
