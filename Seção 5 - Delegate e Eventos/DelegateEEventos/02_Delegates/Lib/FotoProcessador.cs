using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Delegates.Lib
{
    public class FotoProcessador
    {
        //Abstração dos efeitos
        public delegate void FotoFiltroHandler(Foto foto);


        //Se o tipo da variável é do nome do delegate ela é o proprio delegate
        //Ponteiros
        //Nessa propriedade tem que se atrelar os evetnos que queremos utilizar
        public static FotoFiltroHandler Filtros;

        public static void Processar(Foto foto) 
        {
            //FotoFiltro filtros = new FotoFiltro();

            //filtros.Colorir(foto);
            //filtros.GerarThumb(foto);
            //filtros.PretoBranco(foto);
            //filtros.RedimensionarTamanhoMedio(foto);


            //Do mesmo modo que a propriedade filtro é usada para atribuir os métodos ela tem que ser usada para executar os métodos.
            //Por isso tem que chamar ela e passar como parametro foto
            //Executa o método que foi vinculado ao delegate
            Filtros(foto);
        }
    }
}
