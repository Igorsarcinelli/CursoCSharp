using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class CriandoFuncoes
    {
        public static void Executar()
        {
            Console.WriteLine("Digite três números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int n3 = int.Parse(Console.ReadLine());

            double resultado = Maior(n1, n2, n3);
            Console.WriteLine("Maior =" + resultado);
        }

        static int Maior(int a , int b, int c) {
            int m;
            if (a > b && a > c)
            {
                m = a;
            }

            else if (b > a && b > c)
            {
                m = b;
            }

            else
            {
                m = c;
            }
            return m;
        }
    }
}
