using CursoCSharp.ClassesEObjetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MeusExercicios
{
    internal class LerDados
    {
        public static void Executar()
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();

            Console.WriteLine("Informe o nome: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade: ");
            p1.Idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Informe a idade: ");
            p2.Idade = int.Parse(Console.ReadLine());

            if (p1.Idade > p2.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p1.Nome}");
            }
            else if (p2.Idade > p1.Idade)
            {
                Console.WriteLine($"Pessoa mais velha: {p2.Nome}");
            }
            else
            {
                Console.WriteLine("Ambas as pessoas têm a mesma idade.");
            }
        }

    }
}

