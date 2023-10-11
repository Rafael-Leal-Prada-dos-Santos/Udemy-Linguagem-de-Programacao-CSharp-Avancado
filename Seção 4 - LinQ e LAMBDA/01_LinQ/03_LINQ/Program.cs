using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Usuario> lista = new List<Usuario>();

            lista.Add(new Usuario() { Nome = "rafael", Email = "rafael@gmail.com" });
            lista.Add(new Usuario() { Nome = "richard", Email = "richard@hotmail.com" });
            lista.Add(new Usuario() { Nome = "renato", Email = "renato@ig.com" });
            lista.Add(new Usuario() { Nome = "jeferson", Email = "jeferson@hotmail.com" });
            lista.Add(new Usuario() { Nome = "pedro", Email = "pedro@gmail.com" });

            var listaFiltrada = lista.Where(a => a.Email.Contains("@gmail.com")).Select(a => a);

            foreach (var item in listaFiltrada) 
            {
                Console.WriteLine(item.Nome);
            }

            Console.ReadKey();

        }
    }
}
