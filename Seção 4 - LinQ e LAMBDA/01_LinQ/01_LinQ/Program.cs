using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_LinQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] lista = { 3, 9, 4, 6, 20, 10, 60, 90, 80, 50 };

            //(Filtro)Pesquisar valores na lista que atendam uma determinada condição
            lista.Where(a => a > 10);

            //Selecionar os dados que quer apresentar
            lista.Select(a => a);

            Console.WriteLine("Imprimindo a lista filtrada pelo Where");

            IEnumerable<int> ListaFiltrada = lista.Where(a => a > 10).Select(a => a);

            foreach (int item in ListaFiltrada) 
            {
                Console.WriteLine(item);
            }

            //Ordenar por ordem crescente
            ListaFiltrada = lista.Where(a => a > 10).OrderBy(a => a).Select(a => a);

            Console.WriteLine("Imprimindo a lista ordenada ");

            foreach (int item in ListaFiltrada)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }

        /*
         * LinQ é uma representação da Linguagem SQL no C#
         * Ele manipula qualquer tipo de dados que trabalha com "navegação"
         * Arrays, Listas, Coleções, Dicionários
         */

        /* 
         * LAMBDA
         *Recurso no C# que permite usar expressões no código
         *(entrada/ parametro/ variavel que vai representar o valor dentro da lista) 
         *  => (expressão)
         */
    }
}
