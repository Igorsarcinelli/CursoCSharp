using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class EstruturaIF
    {
        public static void Executar()
        {
            // retorna true ou false
            bool bomComportamento = false;
            string entrada;

            Console.WriteLine("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("Possui bom corpotamento (S/N): ");
            entrada = Console.ReadLine();


            // ou entrada.ToLower() == "s"
            // converter toda a entrada para minusculo
            if (entrada == "S" || entrada == "s") 
                bomComportamento = true;

            // Se a nota é maior q 9 e o bom comportamento for true
            if (nota >= 9.0 && bomComportamento)
            {
                Console.WriteLine("Parabéns");
            }
                
        }
            

    }
}
