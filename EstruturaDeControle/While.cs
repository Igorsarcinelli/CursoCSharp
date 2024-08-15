using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class While
    {
        public static void Executar()
        {
            // serve para ser executado enquanto o bloco for verdadeiro


            int palpite = 0;
            Random random = new Random();

            int numSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativasRestantes = 5;
            int tentativas = 0;
                                                // essa ! converte para true
            while (tentativasRestantes > 0 && !numeroEncontrado)
            {
                Console.WriteLine("Informe um número: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativasRestantes--;

                if (numSecreto == palpite)
                {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Numero encontrado em {tentativas} tentativas");
                    Console.BackgroundColor = corAnterior;
                }
                else if (palpite > numSecreto)
                {
                    Console.WriteLine($"Menor..., você tem {tentativasRestantes} tentativas");
                }
                else
                {
                    Console.WriteLine($"Maior..., você tem {tentativasRestantes} tentativas");
                }


            }
        }
    }
}
