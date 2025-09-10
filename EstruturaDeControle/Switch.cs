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
            Console.WriteLine("Informe onde você trabalha: \n 0-Aracruz \n 1-Vitoria \n 2-Joao Neiva");
            int.TryParse(Console.ReadLine(), out int numEscolhido);

            switch (numEscolhido)
            {
                case 0:
                    Console.WriteLine("Você é da cidade de Aracruz.");
                    break;
                case 1:
                    Console.WriteLine("Voce é da cidade de vitoria");
                    break;
                case 2:
                    Console.WriteLine("Voce é da cidade de João neiva");
                    break;
                default:
                    Console.WriteLine("Numero invalido");
                    break;
            }

        }
    }
}
