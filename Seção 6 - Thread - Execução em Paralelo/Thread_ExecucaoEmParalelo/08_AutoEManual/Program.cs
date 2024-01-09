using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08_AutoEManual
{
    class Program
    {
        //Dependencia das threads
        static AutoResetEvent auto01;
        static ManualResetEvent manual01;

        static void Main(string[] args)
        {
            manual01 = new ManualResetEvent(false);

            auto01 = new AutoResetEvent(false);

            Thread t1 = new Thread(Executa01);
            t1.Start();

            Thread t2 = new Thread(Executa02);
            t2.Start();

            Thread.Sleep(5000);
            manual01.Set(); // Liberado
            manual01.Reset(); // Parar novamente

            auto01.Set();

            Thread.Sleep(5000);
            manual01.Set(); // Liberado
            auto01.Set(); // Parar novamente

            Console.ReadKey();
        }

        static void Executa01() 
        {
            Console.WriteLine("01 - Iniciado Executa01");

            manual01.WaitOne();//Bloqueado
            Console.WriteLine("01 - Em execução 01 Executa01");
            Console.WriteLine("01 - Em execução 02 Executa01");
            Console.WriteLine("01 - Finaliza Executa01");
        }
        static void Executa02()
        {
            Console.WriteLine("01 - Iniciado Executa02");
            auto01.WaitOne();//Bloqueado
            Console.WriteLine("01 - Em execução 01 Executa02");
            Console.WriteLine("01 - Em execução 02 Executa02");
            auto01.WaitOne();//Bloqueado
            Console.WriteLine("01 - Finaliza Executa02");
        }
    }
}
