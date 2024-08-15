using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class LendoDados
    {
        public static void Executar()
        {
            Console.Write("Qual seu nome? ");
            
            // serve para ler os dados 
            string nome = Console.ReadLine();

            Console.WriteLine("Qual sua idade? ");


            // parse não é uma forma tão segura
            // int.parse transforma em valor numerico
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine($"Seu nome é {nome} e sua idade é {idade}");
        }
    }
}
