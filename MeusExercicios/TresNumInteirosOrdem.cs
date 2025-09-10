using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MeusExercicios
{
    internal class TresNumInteirosOrdem
    {
        public static void Executar()
        {
            Console.WriteLine("Informe um número: ");
            string entrada1 = Console.ReadLine();
            int.TryParse(entrada1, out int num1);
            Console.WriteLine("Informe o segundo número: ");
            string entrada2 = Console.ReadLine();
            int.TryParse(entrada2, out int num2);
            Console.WriteLine("Informe o terceiro número: ");
            string entrada3 = Console.ReadLine();
            int.TryParse(entrada3, out int num3); 


            if (num1 > num2 && num2 > num3) 
            {
                Console.WriteLine($"{num1},{num2},{num3}");
            }
            else if (num1 > num3 && num3 > num2)
            {
                Console.WriteLine($"{num1},{num3},{num2}");
            }
            else if (num2 > num1 && num1 > num3)
            {
                Console.WriteLine($"{num2},{num1},{num3}");
            }

            // continuar
        }
    }
}
