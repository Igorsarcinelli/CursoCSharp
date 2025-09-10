using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MeusExercicios;
internal class CalculoFatorial
{
    public static void Executar()
    {
        while (true)
        {
            Console.WriteLine("Digite S para sair ou um número para calcular o fatorial: ");
            string opcao = Console.ReadLine();

            if (opcao == "s" || opcao == "S")
                break;
            else
            {
                int valor = Convert.ToInt16(opcao);

                int resultado = 1;
                for (int i = 1; i <= valor; i++)
                {
                    Console.WriteLine(i);
                    resultado *= i;
                }
                Console.WriteLine("Resultado final fatorial é: " + resultado);

            }
        }

    }
}
