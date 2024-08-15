using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Inferencia
    {
        public static void Executar()
        {   
            // o C# ira identificar qual a variável essa do tipo string
            var nome = "Leonardo";

            // vc tem q fornecer o valor 
            var idade = 32;

            int a;
            a = 30;

            Console.WriteLine(nome + ", sua idade é " + idade + "tem " + a + " de profissão");
        }


    }
}
