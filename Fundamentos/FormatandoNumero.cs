using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class FormatandoNumero
    {
        public static void Executar()
        {
            double valor = 15.175;
            // Uma casa depois da virgula
            Console.WriteLine(valor.ToString("F1"));
            // ou
            Console.WriteLine(valor.ToString("#.##"));

            // valor monetário
            Console.WriteLine(valor.ToString("C"));

            // Valor percentual
            Console.WriteLine(valor.ToString("P"));

            int inteiro = 256;
            // adicionar numeros para ter 10 caracteres
            Console.WriteLine(inteiro.ToString("D10"));
        }
    }
}
