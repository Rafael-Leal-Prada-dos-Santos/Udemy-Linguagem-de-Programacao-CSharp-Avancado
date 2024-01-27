using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ValidacaoCustomizada
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario();

            usuario.Nome = "José";
            usuario.Email = "jose";
            usuario.Senha = "1234";

            ValidationContext contexto = new ValidationContext(usuario);

            List<ValidationResult> resultados = new List<ValidationResult>();

            if (!Validator.TryValidateObject(usuario, contexto, resultados, true))
            {
                //mensagens
                foreach (var erro in resultados)
                {
                    Console.WriteLine(erro.ErrorMessage);
                }
            }

            Console.ReadKey();
        }
    }
}
