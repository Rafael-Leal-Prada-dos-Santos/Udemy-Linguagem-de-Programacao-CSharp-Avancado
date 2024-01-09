using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace _02_Thread
{
    class Program
    {

        /*A maneira normal de executar um programa é linha a linha
          Mas por causa da thread ele vai alternando a execução do fluxo principal e do fluxo paralelo
          Quem define o tempo que uma tarefa está em processamento é o Sistema Operacional e é aletaório*/
        static void Main(string[] args)
        {

            //Criação do fluxo pralelo
            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();

            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Main: {i}");
            }

            Console.ReadKey();

        }

        //IO - Entreda e saída de dados 
        //Tela(monitor), Rede, Armazendamento
        static void ThreadRepeticao() 
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Num: {i}");
            }
        }

    }
}
