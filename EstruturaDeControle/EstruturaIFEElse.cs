using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIFEElse
    {
        public static void Executar()
        {
            string entrada;

            Console.WriteLine("Informe sua nota: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 7.0)
            {
                Console.WriteLine("Aprovado");
            }
            else
            {
                Console.WriteLine("Recuperação");
            }
        }
    }
}
