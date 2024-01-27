using MatematicaOperacao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double resultado = Soma.Calcular(1, 2);

            Console.WriteLine("Resultado: {0}", resultado);

            Console.ReadKey();
        }
    }
}
