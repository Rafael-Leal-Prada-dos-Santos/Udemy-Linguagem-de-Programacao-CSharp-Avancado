using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LINQ
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

            Console.WriteLine("Imprimindo a lista filtrada pela forma literal");

            //IEnumerable<int> ListaFiltrada = lista.Where(a => a > 10).Select(a => a);

            //Forma literal
            IOrderedEnumerable<int> ListaFiltrada = from a in lista where a > 10 orderby a select a;

            foreach (int item in ListaFiltrada)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}
