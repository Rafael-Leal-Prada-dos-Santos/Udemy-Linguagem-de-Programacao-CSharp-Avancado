using _02_Delegates.Lib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegates
{
    class Program
    {
        static void Main(string[] args)
        {
            //Tela de cadastro de usuario : Thumb (Foto de perfil)
            //Definiu o método que está vinculado ao handler para ser executado
            //Filtros = ponteiro gerar thumbnail
            Foto foto = new Foto() { Nome = "perfil.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.Filtros = new FotoFiltro().GerarThumb;
            FotoProcessador.Processar(foto);

            //Tela de cadastro de produtos : Colorir + TamanhoMedio (Foto de perfil)
            Foto foto2 = new Foto() { Nome = "produto.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.Filtros = new FotoFiltro().Colorir;
            FotoProcessador.Filtros += new FotoFiltro().RedimensionarTamanhoMedio;
            FotoProcessador.Processar(foto2);


            //Tela de cadastro de Albuns do Usuario Retro : PretoBranco (Foto de perfil)
            Foto foto3 = new Foto() { Nome = "album.jpg", TamanhoX = 1920, TamanhoY = 1080 };
            FotoProcessador.Filtros = new FotoFiltro().PretoBranco;
            FotoProcessador.Processar(foto3);


            Console.ReadKey();
        }
    }
}
