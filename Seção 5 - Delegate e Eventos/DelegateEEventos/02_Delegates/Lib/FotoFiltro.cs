using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegates.Lib
{
    public class FotoFiltro
    {
        public void Colorir(Foto foto) 
        {
            //Algoritimo
            Console.WriteLine("FotoFiltro > Colorir: " + foto.Nome);
        }

        public void GerarThumb(Foto foto)
        {
            //Algoritimo
            Console.WriteLine("FotoFiltro > GerarThumb: " + foto.Nome);
        }

        public void PretoBranco(Foto foto)
        {
            //Algoritimo
            Console.WriteLine("FotoFiltro > PretoBranco: " + foto.Nome);
        }

        public void RedimensionarTamanhoMedio(Foto foto)
        {
            //Algoritimo
            Console.WriteLine("FotoFiltro > RedimensionarTamanhoMedio: " + foto.Nome);
        }
    }
}
