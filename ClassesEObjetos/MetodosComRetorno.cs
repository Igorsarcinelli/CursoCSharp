using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos
{
    class CalculadoraComum
    {
        public int Somar(int a, int b)
        {
            return a + b;
        }

        public int Subtrair(int a, int b)
        {
            return a - b;
        }

        public int Multiplicar(int a, int b)
        {
            return a * b;
        }
    }

    public class CalculadoraCadeia()
    {
        int memoria;
        public CalculadoraCadeia Numero()
        {
            Console.WriteLine("Informe um número: ");
            int.TryParse(Console.ReadLine(), out int numUsuario);
            memoria = numUsuario;
            return this;
        }

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            Console.WriteLine(memoria);
            return this;
        }

        public CalculadoraCadeia Subtrair(int a)
        {
            memoria -= a;
            Console.WriteLine(memoria);
            return this;
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            Console.WriteLine(memoria);
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

    }
    class MetodosComRetorno
    {
        public static void Executar()
        {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);
            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2,7));
            Console.WriteLine(calculadoraComum.Multiplicar(4, 4));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Numero();

            while (true)
            {
                 
                Console.WriteLine("Escolha uma opção:\n 1- Somar \n 2- Subtrair \n 3-Multiplicar \n 4-Limpar");
                int.TryParse(Console.ReadLine(), out int escolhaUsuario);

                switch (escolhaUsuario)
                {
                    case 1:
                        Console.WriteLine("Informe o numero: ");
                        int.TryParse(Console.ReadLine(), out int a);
                        calculadoraCadeia.Somar(a);
                        continue;
                    case 2:
                        Console.WriteLine("Informe o numero: ");
                        int.TryParse(Console.ReadLine(), out int b);
                        calculadoraCadeia.Subtrair(b);
                        continue;
                    case 3:
                        Console.WriteLine("Informe o numero: ");
                        int.TryParse(Console.ReadLine(), out int c);
                        calculadoraCadeia.Multiplicar(c);
                        continue;
                    case 4:
                        calculadoraCadeia.Limpar();
                        calculadoraCadeia.Numero();
                        continue;
                    default:
                        break;
                }
            }

            

        }
    }
}
