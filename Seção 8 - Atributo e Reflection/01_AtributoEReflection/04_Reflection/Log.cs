using _04_Reflection.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Reflection
{
    public class Log
    {
        public static List<object> objetosLog = new List<object>();

        public static void Gravar(object objeto)
        {
            objetosLog.Add(objeto);
        }

        public static void ApresentarLog()
        {
            foreach (object objeto in objetosLog) 
            {
                Console.WriteLine(objeto.GetType());

                if (objeto is Usuario usuario) 
                {

                }

                if (objeto is Carro) 
                {

                }
            }
        }

        public static void ApresentarLog1()
        {
            foreach (object objeto in objetosLog)
            {
                Console.WriteLine("--------Nome Classe: {0}--------",objeto.GetType().Name);

                foreach (var prop in objeto.GetType().GetProperties()) 
                {
                    Console.WriteLine(prop.Name + ":" + prop.GetValue(objeto));
                }
            }
        }


        //public static List<Usuario> usuarios = new List<Usuario>();
        //public static List<Carro> carros = new List<Carro>();



        //public static void GravarLogUsuario(Usuario usuario) 
        //{
        //    usuarios.Add((Usuario)usuario.Clone());
        //}

        //public static void GravarLogCarro(Carro carro)
        //{
        //    carros.Add((Carro)carro.Clone());
        //}

        //public static void ApresentarLog() 
        //{
        //    foreach (Usuario usuario in usuarios) 
        //    {
        //        Console.WriteLine("Nome:{0}, Email: {1}, Senha: {2}", usuario.Nome, usuario.Email, usuario.Senha);
        //    }
        //    foreach (Carro carro in carros)
        //    {
        //        Console.WriteLine("Marca:{0}, Modelo: {1}", carro.Marca, carro.Modelo);
        //    }
        //}
    }
}
