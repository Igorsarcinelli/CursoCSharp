using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class OperadoresLogicos
    {
        public static void Executar()
        {
            var executouTrabalho1 = true;
            var executouTrabalho2 = false;

            // só executa se todos forem verdadeiros 
            var comprouTV50 = executouTrabalho1 && executouTrabalho2;
            Console.WriteLine($"Comprou TV 50? {comprouTV50}");

            var sorvete1 = true;
            var sorvete2 = false;

            // apenas 1 precisa ser verdadeiro
            var comprouSorvete = sorvete1 || sorvete2;
            Console.WriteLine($"Comprou sorvete? {comprouSorvete}");


            // apenas 1 verdadeiro
            var comproutv32 = sorvete1 ^ sorvete2;
            Console.WriteLine($"Comprou sorvete? {comprouSorvete}");
        }

    }
}
