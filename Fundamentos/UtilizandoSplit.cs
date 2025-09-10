using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class UtilizandoSplit
    {
        public static void Executar()
        {
            // Forma de ler varias palavras em uma frase só

            Console.WriteLine("Escreva 4 frutas separadas por espaço");
            string texto = Console.ReadLine();

            // aqui tem que criar um vetor e utilizando o método split
            // informa qual o metodo de separação
            string[] vetor = texto.Split(' ');

            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(vetor[2]);
            Console.WriteLine(vetor[3]);

            
            Console.WriteLine("Escreva 4 frutas separadas por espaço:");
            string texto2 = Console.ReadLine();
            // aqui eu informo que o metodo de separação é ','
            string[] vet = texto.Split(',');
            Console.WriteLine(vetor[0]);
            Console.WriteLine(vetor[1]);
            Console.WriteLine(vetor[2]);
            Console.WriteLine(vetor[3]);

        }
    }
}
