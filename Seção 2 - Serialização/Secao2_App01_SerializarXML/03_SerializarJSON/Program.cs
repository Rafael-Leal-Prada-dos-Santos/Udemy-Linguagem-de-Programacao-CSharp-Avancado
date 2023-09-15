using System;
using _00_Biblioteca;
using System.Text.Json;
using System.IO;

namespace _03_SerializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Lizandra Leal Santos", Cpf = "323.456.789-22", Email = "maria.costa@email.com" };

            string objetoSerializado = JsonSerializer.Serialize(usuario);


            StreamWriter streamWritter = new StreamWriter(@"C:\Users\RAFAEL\OneDrive\Documentos\Arquivo - C# Avançado\serializarJSON.xml");
            
            streamWritter.WriteLine(objetoSerializado);
            streamWritter.Close();

            Console.Write("Codigo Executado com sucesso!");
            Console.ReadKey();
        }
    }
}
