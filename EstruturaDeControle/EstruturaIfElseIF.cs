using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIfElseIF
    {
        public static void Executar()
        {
            Console.WriteLine("Digite a nota do aluno: ");
            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if (nota >= 9.0)
            {
                Console.WriteLine("Que notão");
            }
            else if (nota >= 7.0 && nota < 9.0)
            {
                Console.WriteLine("Aprovado");
            }
            else if (nota < 7.0 && nota > 5)
            {
                Console.WriteLine("Recuperação");
            }
            else
            {
                Console.WriteLine("Reprovado");
            }

        }
    }
}
