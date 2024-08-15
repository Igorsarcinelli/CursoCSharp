using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle {
    internal class Break {
        public static void Executar() {
            Random random = new Random();
            int numero = random.Next(1, 51);
            Console.WriteLine($" O numero que queremos é {numero}");

            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine($"{i} é o numero que queremos?");
                if (i == numero)
                {
                    Console.WriteLine("Sim");
                    break; // encerra o código para que não continue procurando
                }
                else
                {
                    Console.WriteLine("Não");
                }
            }

        }
    }
}
