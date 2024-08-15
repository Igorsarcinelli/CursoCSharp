using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresDeAtribuicao
    {
        public static void Executar()
        {
            var num1 = 3;
            num1 += 10; // adiciona 10 na variável
            Console.WriteLine(num1);
            num1 *= 5;
            num1 /= 2;
            Console.WriteLine(num1);

            int a = 1;
            int b = a;

            a++; // incrementa 1
            b--; // decrementa 1
            Console.WriteLine(a);
            Console.WriteLine(b);

        }
    }
}
