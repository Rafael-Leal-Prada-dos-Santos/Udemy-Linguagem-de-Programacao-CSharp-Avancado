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

            Carro carro2 = Serializador.Desserializar<Carro>();
            Casa casa2 = Serializador.Desserializar<Casa>();
            Usuario usuario2 = Serializador.Desserializar<Usuario>();

            Console.WriteLine($"Carro2: {carro2.Marca} - {carro2.Modelo}");
            Console.WriteLine($"Casa2: {casa2.Cidade} - {casa2.Endereco}");
            Console.WriteLine($"Usuario2: {usuario2.Nome} - {usuario2.Email}");

            Console.ReadKey();
        }
    }
}
