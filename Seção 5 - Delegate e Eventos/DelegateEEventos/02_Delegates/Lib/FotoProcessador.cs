using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegates.Lib
{
    public class FotoProcessador
    {
        public static void Processador(Foto foto) 
        {
            FotoFiltro filtros = new FotoFiltro();

            filtros.Colorir(foto);
            filtros.GerarThumb(foto);
            filtros.PretoBranco(foto);
            filtros.RedimensionarTamanhoMedio(foto);

        }
    }
}
