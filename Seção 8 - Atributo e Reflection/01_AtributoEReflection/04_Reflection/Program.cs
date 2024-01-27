using _04_Reflection.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Reflection
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario()
            {
                Nome = "José",
                Email = "jose@gmail.com",
                Senha = "12345"
            };

            Log.Gravar(usuario.Clone());

            usuario.Nome = "José Costa";

            Log.Gravar(usuario.Clone());


            Carro carro = new Carro()
            {
                Marca = "Fiat",
                Modelo = "Uno"
            };

            Log.Gravar(carro);

            Log.ApresentarLog();

            Console.WriteLine("Log Gravado!");
            Console.ReadKey();
        }
    }
}
