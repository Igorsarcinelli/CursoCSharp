using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class For
    {// o FOR é mais usado quando você tem um numero determinado de repetições
        public static void Executar()
        {
            Console.WriteLine("Informe a quantidade de pessoas: ");
            int.TryParse(Console.ReadLine(), out int qtdPessoas);

            for (int i = 0; i < qtdPessoas; i++)
            {
                Console.WriteLine("Pessoa número: {0}", i + 1);
            }

        
        }
    }
}
