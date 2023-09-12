using System;
using System.IO;
using _00_Biblioteca;
using System.Xml.Serialization;

namespace _01_SerializarXML
{
    class Program
    {
        static void Main(string[] args)
        {
            Usuario usuario = new Usuario() { Nome = "Rafael Santos da Siltva" , Cpf="123.456.789-22", Email="teste@email.com"};


            //XmlSerializer serializadorXml = new XmlSerializer(usuario.GetType());

            XmlSerializer serializadorXml = new XmlSerializer(typeof(Usuario));

            StreamWriter stream = new StreamWriter(@"C:\Users\RAFAEL\OneDrive\Documentos\Arquivo - C# Avançado\serializarXML.xml");

            serializadorXml.Serialize(stream , usuario);
        }
    }
}
