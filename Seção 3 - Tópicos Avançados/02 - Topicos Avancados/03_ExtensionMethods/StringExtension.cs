using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_ExtensionMethods
{
    //A classe tem que ser estática para que se torne um extension method
    public static class StringExtension
    {
        // O metodo tem que receber a classe que quer se estender através da palavra chave this + nome da Classe
        public static string PrimeriaLetraEmMaiusculo(this String str) 
        {

            if (str.Length > 0)
            {
                string primeiraLetra = str.Substring(0, 1);
                

                string restanteDoTexto = str.Substring(1);

                return primeiraLetra.ToUpper() + restanteDoTexto;
            }
            else
            {
                return str;
            }
        }
    }
}
