using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class NotacaoPonto
    {
        public static void Executar()
        {
            var saudacao = "Olá Mundo".ToUpper(); // deixar maiusculo
            var nomeEmIngles = "Hello, good morning".Replace("morning", "dia");

            Console.WriteLine(saudacao);
            Console.WriteLine(nomeEmIngles);

            // Para pegar o tamanho da string
            Console.WriteLine("Teste".Length);
        }
    }
}
