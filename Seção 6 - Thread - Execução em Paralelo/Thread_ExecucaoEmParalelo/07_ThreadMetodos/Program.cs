using System;
using System.Threading;

namespace _07_ThreadMetodos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inicio do nosso programa");
            Thread.Sleep(2000);
            Console.WriteLine("Términod do nosso programa");

            Thread t1 = new Thread(ThreadRepeticao);
            t1.Start();
            t1.Join(); //Faz com que a thread principal do progrma espere esta trhead completar para prosseguir

            Console.ReadKey();
        }

        static void ThreadRepeticao(object id)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Thread: {id} - Num: {i} {Thread.CurrentThread.ManagedThreadId}");
            }
        }
    }
}
