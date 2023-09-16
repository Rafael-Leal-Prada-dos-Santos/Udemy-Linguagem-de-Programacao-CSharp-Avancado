using System;
using _01_Generics.Modelo;

namespace _01_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = new Carro()
            {
                Marca = "FIAT",
                Modelo = "UNO"
            };

            Casa casa = new Casa()
            {
                Cidade = "Brasilia",
                Endereco = "Amador blueno 393"
            };

            Usuario usuario = new Usuario() 
            {
                Nome = "MAria",
                Email = "maria@gmail.com",
                Senha = "123456"
            };

            Serializador.Serializar(carro);
            Serializador.Serializar(casa);
            Serializador.Serializar(usuario);

            Carro carro2 = Serializador.Desserializar();
        }
    }
}
