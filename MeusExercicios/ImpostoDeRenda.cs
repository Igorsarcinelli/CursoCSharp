using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


// Em um país imaginário denominado Lisarb, todos os habitantes ficam felizes em pagar seus impostos, pois sabem
// que nele não existem políticos corruptos e os recursos arrecadados são utilizados em benefício da população, sem
// qualquer desvio. A moeda deste país é o Rombus, cujo símbolo é o R$.

// Lembre que, se o salário for R$ 3002.00, a taxa que incide é de 8% apenas sobre R$ 1000.00, pois a faixa de
//salário que fica de R$ 0.00 até R$ 2000.00 é isenta de Imposto de Renda. No exemplo fornecido (abaixo), a taxa é
//de 8% sobre R$ 1000.00 + 18% sobre R$ 2.00, o que resulta em R$ 80.36 no total. O valor deve ser impresso com
// duas casas decimais.
namespace CursoCSharp.MeusExercicios
{
    internal class ImpostoDeRenda
    {
        public static void Executar()
        {
            Console.WriteLine("Infome o seu sálario: ");
            double salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            double calculoSalario = 0.0;

            if (salario <= 2000.00)
            {
                Console.WriteLine("Isento");
            }

            else if (salario <= 3000.00)
            {
                calculoSalario = (salario - 2000.00) * 0.08 ;
            }

            else if (salario <= 4500.00)
            {
                calculoSalario = (salario - 3000.00) * 0.18 + 1000.0 * 0.08;
            }
            else
            {
                calculoSalario = (salario - 4500.00) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
            }

            Console.WriteLine(calculoSalario);

        }
    }
}
