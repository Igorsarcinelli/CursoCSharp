using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos
{
        public class CalculadoraEstatica()
        {
            public static int Somar(int a, int b)
            {
                return a + b;
            }

            public static int Subtrair(int a, int b)
            {
                return a - b;
            }

            public static int Multiplicar(int a, int b)
            {
                return a * b;
            }

        public class MetodosEstaticos
        {
            public static void Executar()
            {
                var resultado = CalculadoraEstatica.Subtrair(5, 2);
                Console.WriteLine($"O resultado é: {resultado}");

                Console.WriteLine(CalculadoraEstatica.Multiplicar(3, 3));
            }
        }
    }
}

