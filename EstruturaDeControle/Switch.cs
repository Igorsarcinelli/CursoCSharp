using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class Switch
    {
        public static void Executar()
        {
            Console.WriteLine("Avalie meu atendimento com uma nota de 1 a 5: ");
            int.TryParse(Console.ReadLine(), out int nota);

            // deverar ser passado um valor inteiro
            switch (nota) {
                // caso o valor seje 0
                case 0:
                    Console.WriteLine("Pessímo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;
                default:
                    Console.WriteLine("Nota inválida");
                    break;
                }
        }
    }
}
