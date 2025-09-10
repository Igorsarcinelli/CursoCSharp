using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    class EstruturaForeach
    {
        public static void Executar()
        {
            // PERCORRE TODO O CONTEÚDO SEM PRECISAR DE INCREMENTAÇÃO

            Console.WriteLine("Informe seu nome: ");
            string nome = Console.ReadLine();

            foreach (var letra in nome)
            {
                Console.WriteLine("Essa é a ordem do seu nome: {0}", letra);
            }
        }
    }
}
