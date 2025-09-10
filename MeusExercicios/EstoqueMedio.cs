using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MeusExercicios
{
    internal class EstoqueMedio
    {
        public static void Executar()
        {
            double estoqueMedio = 0;

            Console.WriteLine("Infomre a quantidade mínima do produto: ");
            string qtdMin = Console.ReadLine();
            int.TryParse(qtdMin, out int valorMin);
            Console.WriteLine("Informe a quantidade máxima do produto: ");
            string qtdMax = Console.ReadLine();
            int.TryParse(qtdMax, out int valorMax);

            estoqueMedio = (valorMin + valorMax) / 2;

            Console.WriteLine($"A quantidade de estoque média é: {estoqueMedio}");

        }
    }
}
