using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _05_ThreadSafe
{
    class Program
    {
        static int rede = 0;

        static object variavelDeControle = 0;

        /*Tipos de transferencia de fora do computador
        Gerlamente é mais lengo e instável*/

        /*Palavra lock ela vai resevar um recurso para que seja utlizado por 
         uma thread por vez*/
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
            /*Variavel de controle é uma variavel utilizada para verificar
             se os recursos estão sendo utilzados ou não. para que as threads
            não utilizem ao mesmo tempo o mesmo recurso*/

            /*Lock funciona no sistem a e fila FIFO
             Primeiro a entrar e primeiro a sair*/
           
            //Só ira liberar os recursos assim que o For terminar
            for (int i = 0; i < 1000; i++)
            {
                lock (variavelDeControle)
                {
                    Console.WriteLine($"Num: {i}");
                    rede++;
                }
            }

            Console.WriteLine($"Data Final: {DateTime.Now}");
        }
    }
}
