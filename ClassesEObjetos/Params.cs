using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos
{
    class Params
    {
        // PARAMS SERVE PARA PASSAR PARAMETROS VARIÁVEIS DO MESMO TIPO
        // IGUAL ESSE EU PASSO 1,2,3,4,5...
        public static void ContarAteDez(params string[] numeros)
        {
            foreach (var i in numeros)
            {
                Console.WriteLine("{0}\n", i);
            }
        }

        public static void Formatar(int dia, int mes, int ano)
        {
            Console.WriteLine("{0:D2}/{1:D2}/{2}", dia, mes, ano);
        }

        public static void Executar()
        {
            ContarAteDez("1","2","3","4","5","6","7","8","9","10");

            Formatar(mes: 1, dia:23, ano:2002);
        }
    }
}
