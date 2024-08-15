using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MeusExercicios
{
    internal class CalculadoraUsandoClasses
    {
        public double Somar(double a, double b)
        {
            return a + b;
        }

        public double Subtrair(double a, double b)
        {
            return a - b;
        }

        public double Multiplicar(double a, double b)
        {
            return a * b;
        }

        public double Dividir(double a, double b)
        {
            return a / b;
        }
        public static void Executar()
        {
            Console.WriteLine("Informe um numero");
            string entrada1 = Console.ReadLine();
            double.TryParse(entrada1, out double a);

            Console.WriteLine("Informe outro numero");
            string entrada2 = Console.ReadLine();
            double.TryParse(entrada2, out double b);

            
        }
    }
}
