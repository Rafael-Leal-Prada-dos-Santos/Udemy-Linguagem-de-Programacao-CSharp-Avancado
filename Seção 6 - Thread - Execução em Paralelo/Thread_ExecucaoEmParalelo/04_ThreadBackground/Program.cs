using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _04_ThreadBackground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Data Inicial: {DateTime.Now}");

            for (int i = 0; i < 5; i++)
            {
                Thread t1 = new Thread(ThreadRepeticao);
                /*
                 * Propriedade que diz ao compilador que mesmo que exista a thread
                 * no momento que executar a ultima linha do fluxo principal a thread não será mais executada
                */
                t1.IsBackground = true;
                t1.Start();
            }

            Console.ReadKey();
        }

        static void ThreadRepeticao()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Num: {i}");
            }

            Console.WriteLine($"Data Final: {DateTime.Now}");
        }
    }
}
