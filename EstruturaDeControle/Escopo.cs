using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class Escopo
    {
        public static void Executar()
        {
            double preco = 4.345;
            double desconto = 0.0;

            if (preco < 100)
            {
                desconto = preco * 0.1;
            }

            Console.WriteLine(desconto);

        }
     }
}
