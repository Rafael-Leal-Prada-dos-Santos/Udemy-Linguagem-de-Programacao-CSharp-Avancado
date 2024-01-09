using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_VarDinamic
{
    class Program
    {
        static void Main(string[] args)
        {
            object t1 = "";
            object t2 = 123456;

            //t2.Nome; não pode acessar propriedade especifica
            

            t2 = "";

            /* A variável do tipo Var vai representar um dado que eu quiser 
               Porém internamente o var vai receber o tipo através do dado que voce passar.
               No momento que for declarado uma variável var ela tem que obrigatoriamente 
               ser atribuido um valor*/
            
            

            var v1 = ""; //string
            var v2 = 1234; //int32
            //Erro: var v3;
            //Erro v2 = "";

            /* Diferença entre var e object 
             Object é um tipo primitivo e as propriedades 
             podem ser alteradas para qualquer valor.
             Já o var não pode ser atribuido outro tipo através da variável. 
             Mas o seu valor pode ser também alterado, porém para um valor do mesmo
             tipo*/


            //Dynamic.

            /* O tipo Dynamic trabalha em tempo de execução(Runtime).
               Permite que os dados dentro desse objeto sejam acessados 
               sem que eles sejam estruturados , ou seja, que não tenham
               as informações detalhadas de algo Pode colocar qualquer informação dentro dele*/

            dynamic d1 = new Usuario { Nome = "Maria"};

            Console.WriteLine(d1.Nome);
            //Console.WriteLine(d1.Senha); Erro

            d1 = "";

        }

        class Usuario 
        {
            public string Nome { get; set; }
        }
    }
}
