using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    class VariaveisEConstantes
    {   
        public static void Executar()
        {
            //area da circunferencia
            double raio = 4.5;
            // criar constante (não é possível ser alterada)
            const double PI = 3.14;

            double area = PI * raio * raio;
            Console.WriteLine(area);
            
            //Concatenação esse + adiciona essa area
            Console.WriteLine("Área é " + area);


            // Tipos internos
            //Variável True e False
            bool estaChovendo = true;
            Console.WriteLine("Está chovendo? " + estaChovendo);

            // A diferença do tipo byte é a capacidade de armazenamento
            // Usado para economizar memória
            // byte de 0 a 256
            byte idade = 45;
            Console.WriteLine("Sua idade é " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine(saldoDeGols);

            //short

            // É o mais usado
            int menorValorInt = int.MinValue;
            Console.WriteLine(menorValorInt);

            // inteiro sem sinal
            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine(populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine(menorValorLong);

            // VALORES REAIS
            float precoComputador = 1299.99f; // Obriado a adicionar o f
            // se não colocar o f ele vai para double por padrão
            Console.WriteLine(precoComputador);

            double valorDeMercadoApple = 1000.000;//mais usados
            Console.WriteLine(valorDeMercadoApple);

            // Uma unica letra
            char letra = 'A';
            Console.WriteLine(letra);

            string texto = "Ola mundo";
            Console.WriteLine(texto);
        }
    }
}
