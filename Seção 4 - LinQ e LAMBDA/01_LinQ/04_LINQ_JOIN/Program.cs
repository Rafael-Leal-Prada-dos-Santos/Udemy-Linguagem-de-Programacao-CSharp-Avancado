using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_LINQ_JOIN
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Autor> listaAutor = new List<Autor>();

            listaAutor.Add(new Autor() { ID = 1, Nome = "Leonardo"});
            listaAutor.Add(new Autor() { ID = 2, Nome = "Maria" });
            listaAutor.Add(new Autor() { ID = 3, Nome = "Jose" });

            List<Livro> listaLivros = new List<Livro>();

            listaLivros.Add(new Livro() { Id = 1, IDAutor = 2, Titulo = "Amor amado" });
            listaLivros.Add(new Livro() { Id = 2, IDAutor = 2, Titulo = "Bem amado" });
            listaLivros.Add(new Livro() { Id = 1, IDAutor = 3, Titulo = "Um espião em Washington" });
            listaLivros.Add(new Livro() { Id = 1, IDAutor = 1, Titulo = "A Vida na terra" });

            var listaJoin = from livro in listaLivros
                            join autor in listaAutor
                            on livro.IDAutor equals autor.ID
                            select new { livro.Titulo, autor.Nome};
            //select new { livro.Titulo, autor.Nome}; -> Tipo anônimo


            foreach (var item in listaJoin) 
            {
                Console.WriteLine($"Livro: {item.Titulo} - Autor: {item.Nome}");
            }

            Console.ReadKey();
        }
    }
}
