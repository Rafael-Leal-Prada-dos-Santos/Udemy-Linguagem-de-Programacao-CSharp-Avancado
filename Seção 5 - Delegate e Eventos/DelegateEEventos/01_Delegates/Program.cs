using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Delegates
{
    class Program
    {
        delegate int Calcula(int a, int b);

        //Após a declaração do delegate podem ser feitos declarações de ponteiros
        //que tenham a mesma quantidade de parametros que o delegate

        static void Main(string[] args)
        {
            /* modo tradicional
               int soma = Soma(10, 20);
               int subtracao = Subtrair(20, 10);
           */

            //Ponteiro para chamar a operação de soma de forma abstrata
            //A função Soma foi compativel pois tem a mesma quantidade de parametros
            //Variável que está referenciando o método Soma
            Calcula calc = new Calcula(Soma);
            int soma = calc(10, 20);


            Calcula calc1 = new Calcula(Subtrair);
            int subtracao = calc1(20, 10);


            Console.WriteLine("Soma: " + soma);
            Console.WriteLine("Subtracao: " + subtracao);

            Console.ReadKey();

        }

        static int Soma(int a, int b) 
        {
            return a + b;
        }
        static int Subtrair(int a, int b)
        {
            return a - b;
        }

        /* É um ponteiro onde vai ter registro de um método 
          Ele é benéfico para fazer abstração de código. */
    }
}
