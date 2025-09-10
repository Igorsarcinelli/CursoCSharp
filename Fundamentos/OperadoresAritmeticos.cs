using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresAritmeticos
    {
        public static void Executar()
        {
            // Preço Desconto
            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - (total * desconto);
            Console.WriteLine($"O preço final é {totalComDesconto}");

            // IMC
            double peso = 61;
            double altura = 1.70;

            // função math pow para elevar
            double calculoDeIMC = peso / Math.Pow(altura, 2);
            Console.WriteLine($"O IMC do paciente é {calculoDeIMC}");

            // Calculo de numero par ou impar 
            int par = 52;
            int impar = 13;
            // calcula o resto 
            Console.WriteLine($"{par} tem resto {par % 2}");
            Console.WriteLine($"{impar} tem resto {impar % 2}");

        }
    }
}
