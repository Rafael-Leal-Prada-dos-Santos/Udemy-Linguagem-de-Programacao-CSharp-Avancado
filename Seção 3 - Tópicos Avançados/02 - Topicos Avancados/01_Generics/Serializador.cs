using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;
using Newtonsoft.Json;

namespace _01_Generics
{
    public class Serializador 
    {
        public static void Serializar(object objeto)
        {
            //StreamWriter sw = new StreamWriter($@"C:\Users\RAFAEL\OneDrive\Documentos\Arquivo - C# Avançado\03_(NomeDaClasse).txt");
            //StreamWriter sw = new StreamWriter($@"C:\Users\RAFAEL\OneDrive\Documentos\Arquivo - C# Avançado\03_{objeto.GetType().Name}.txt");
            StreamWriter sw = new StreamWriter($@"C:\Users\iport-dev\OneDrive - Iport Solutions S.A\Documentos\Arquivo - C# Avançado\03_{objeto.GetType().Name}.txt");

            string json = JsonConvert.SerializeObject(objeto);

            sw.Write(json);
            sw.Close();

            Console.WriteLine("Método de serializar executado com sucesso!");
        }

        public static T Desserializar<T>()
            where T : class
        {
            //StreamReader sr = new StreamReader($@"C:\Users\RAFAEL\OneDrive\Documentos\Arquivo - C# Avançado\03_{nameof(T)}.txt");
            StreamReader sr = new StreamReader($@"C:\Users\iport-dev\OneDrive - Iport Solutions S.A\Documentos\Arquivo - C# Avançado\03_{typeof(T).Name}.txt");

            string conteudo = sr.ReadToEnd();
            sr.Close();

            return JsonConvert.DeserializeObject<T>(conteudo);
        }
    }
}
