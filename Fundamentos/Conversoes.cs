using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class Conversoes
    {
        public static void Executar()
        {   
            // devemos tomar cuidado para que não haja perda de informções
            // o int é maior que o double
            int inteiro = 10;
            double quebrado = inteiro;

            // aqui iremos perder dados, pelo double ser maior
            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine($"Nota Truncada {notaTruncada}");
        
            // forma mais segura para mudar de uma string para um inteiro
            // caso não informe um numero ele seta como 0 

            Console.WriteLine("Digite um número");
            string palavra = Console.ReadLine();
            int numero;
            int.TryParse( palavra, out numero);
            Console.WriteLine($"Você digitou {numero}");

            // jeito mais facil escrevendo o int diretamente no código
            int.TryParse(palavra, out int numero2);
            Console.WriteLine($"Você digitou {numero2}");

            double a;
            float b;

            // Como essa transformação a gente perde dados 
            a = 5.1;
            // é necessário informar de forma explcicita
            b = (float)a;
        }

    }
}
