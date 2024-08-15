using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class For
    {// o FOR é mais usado quando você tem um numero determinado
        public static void Executar()
        {
            // maneira simplificada
            // for(int i = 1; i <= 10; i++)

            double somatorio = 0;
            string entrada;

            Console.WriteLine("Informe o tamanho da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for(int i = 1; i <= tamanhoTurma; i++)
            {
                Console.WriteLine($"Informe a nota do aluno {i}");
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double mediaTurma = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine($"A média da turma foi {mediaTurma}");
        }
    }
}
