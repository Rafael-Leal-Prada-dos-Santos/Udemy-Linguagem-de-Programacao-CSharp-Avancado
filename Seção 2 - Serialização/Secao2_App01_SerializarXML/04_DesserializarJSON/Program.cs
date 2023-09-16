using _00_Biblioteca;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Text.Json;

namespace _04_DesserializarJSON
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReader = new StreamReader(@"C:\Users\RAFAEL\OneDrive\Documentos\Arquivo - C# Avançado\serializarJSON.xml");

            string usuarioString = streamReader.ReadToEnd();
            streamReader.Close();

            Usuario usuario = JsonConvert.DeserializeObject<Usuario>(usuarioString);


            Console.WriteLine("Nome: {0}, Cpf: {1}, E-mail: {2}", usuario.Nome, usuario.Cpf, usuario.Email);
            Console.ReadKey();
        }
    }
}
