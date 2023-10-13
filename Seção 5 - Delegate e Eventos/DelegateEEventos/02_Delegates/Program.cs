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
            Foto foto = new Foto() { Nome = "foto.jpg" , TamanhoX = 1920, TamanhoY = 1080};
            FotoProcessador.Processador(foto);


            Console.ReadKey();
        }
    }
}
