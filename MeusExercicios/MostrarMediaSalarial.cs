using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MeusExercicios
{
    class MostrarMediaSalarial
    {
        public static void Executar()
        {
            Pessoa p1 = new Pessoa();
            Pessoa p2 = new Pessoa();
            Pessoa p3 = new Pessoa();

            Console.WriteLine("Informe o nome do funcionário: ");
            p1.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salario do funcionário: ");
            p1.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do funcionário: ");
            p2.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salario do funcionário: ");
            p2.Salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Informe o nome do funcionário: ");
            p3.Nome = Console.ReadLine();
            Console.WriteLine("Informe o salario do funcionário: ");
            p3.Salario = float.Parse(Console.ReadLine());

            float mediaSalarial = (p1.Salario + p2.Salario + p3.Salario) / 3;

            Console.WriteLine($"De acordo com os funcionários fornecidos" +
                $"a média salarial foi: {mediaSalarial}");

        }
    }
}
