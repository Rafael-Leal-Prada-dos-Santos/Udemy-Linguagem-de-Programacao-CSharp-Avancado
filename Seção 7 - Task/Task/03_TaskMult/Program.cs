using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace _03_TaskMult
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Task> lista = new List<Task>();
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));
            lista.Add(Task.Factory.StartNew(Metodo01));

            Task.WaitAll(lista.ToArray());

            string[] enderecos = new string[] { "https://www.google.com.br" };

            var listaEnd = from endereco in enderecos select DownloadPagina(endereco);

            Task.WaitAll(listaEnd.ToArray());


            Console.WriteLine("Programa finalizado");

            Console.ReadKey();
        }
        static void Metodo01()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine($"Valor: {i} - {Task.CurrentId}");
            }
        }

        static async Task DownloadPagina(string endereco)
        {
            WebClient webClient = new WebClient();
            string html = await webClient.DownloadStringTaskAsync(endereco);

            Console.WriteLine($"Download Realizado para Pagina: {endereco}");
        }
    }
}
