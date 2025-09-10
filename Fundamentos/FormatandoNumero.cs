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
            double valor1 = 15.175;
            double valor2 = 14312.455;

            // FORMATAÇÃO PARA 2 CASAS DECIMAIS DEPOIS DO .
            Console.WriteLine(valor1.ToString("F"));

            // FORMATAÇÃO PARA VALOR MONETÁRIO C DE CURRENCY
            Console.WriteLine(valor1.ToString("C"));

            // FORMATAÇÃO PARA PORCENTAGEM
            Console.WriteLine(valor1.ToString("P"));

            // FORMATAÇÃO SEPARANDO OS MILHARES
            Console.WriteLine(valor2.ToString("N"));


        }
    }
}
