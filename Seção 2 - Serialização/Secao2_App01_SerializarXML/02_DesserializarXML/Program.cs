using System;
using _00_Biblioteca;
using System.IO;
using System.Xml.Serialization;

namespace _02_DesserializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader steramReader = new StreamReader(@"C:\Users\RAFAEL\OneDrive\Documentos\Arquivo - C# Avançado\serializarXML.xml");

            XmlSerializer serializador = new XmlSerializer(typeof(Usuario));

            Usuario usuario = serializador.Deserialize(steramReader) as Usuario;

            Console.WriteLine("Usuario(Nome): {0}, CPF: {1} e Email: {2}", usuario.Nome, usuario.Cpf, usuario.Email);
            Console.ReadKey();
        }
    }
}
