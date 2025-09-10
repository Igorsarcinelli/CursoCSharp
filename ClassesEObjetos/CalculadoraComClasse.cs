using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos;
public class CalculadoraComClasse
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

    public class CalculadoraCadeia
    {
        int memoria;

        public CalculadoraCadeia Somar(int a)
        {
            memoria += a;
            return this; // o this retorna a propria CalculadoraCadeia, retorna a instancia atual que está usando
        }

        public CalculadoraCadeia Multiplicar(int a)
        {
            memoria *= a;
            return this;
        }

        public CalculadoraCadeia Limpar()
        {
            memoria = 0;
            return this;
        }

        public CalculadoraCadeia Imprimir()
        {
            Console.WriteLine(memoria);
            return this;
        }

    }

    public static void Executar()
    {
        Console.WriteLine("Informe um número: ");
        
    }
}
