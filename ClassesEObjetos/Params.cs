using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos
{
    class Params
    {
        public static void Recepicionar(params string[] pessoas)
        {
            foreach (var pessoa in pessoas)
            {
                Console.WriteLine("Ola{0}", pessoa);
            }
        }
        public static void Executar()
        {
            Recepicionar("Pedro", "Manu", "Igor");
        }
    }
}
