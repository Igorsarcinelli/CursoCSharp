using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MeusExercicios
{
    internal class Calculadora
    {
        public static void Executar()
        {
            string sair = "sim";
            bool continuar = false;

            while (!continuar)
            {

                Console.WriteLine("Informe um número");
                string entrada1 = Console.ReadLine();
                double.TryParse(entrada1, out double num1);

                Console.WriteLine("Informe outro número");
                string entrada2 = Console.ReadLine();
                double.TryParse(entrada2, out double num2);

                double soma = num1 + num2;
                double subtracao = num1 - num2;
                double multiplicacao = num1 * num2;
                double divisao = num1 / num2;

                Console.WriteLine("Informe [1]somar \n [2]subtrair \n [3]multiplicar \n [4]dividir");
                string entrada3 = Console.ReadLine();
                int.TryParse(entrada3, out int selecao);



                switch (selecao)
                {
                    case 0:
                    case 1:
                        Console.WriteLine(soma);
                        break;
                    case 2: 
                        Console.WriteLine(subtracao);
                        break;
                    case 3:
                        Console.WriteLine(multiplicacao);
                        break;
                    case 4:
                        Console.WriteLine(divisao);
                        break;
                }

                Console.WriteLine("Deseja sair?[sim][não]");
                string entrada4 = Console.ReadLine().ToLower();
                
                if (entrada4 == "sim")
                {
                    continuar = true;
                }

                else
                {
                    continuar = false;
                }


            }
        }
    }
}