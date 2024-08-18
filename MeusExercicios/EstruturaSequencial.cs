using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MeusExercicios
{
    internal class EstruturaSequencial
    {
        public static void Executar()
        {
            Console.WriteLine("Informe 3 numeros de ponto flutuante");
            
            string[] nums = Console.ReadLine().Split(' ');

            double num1 = double.Parse(nums[0]);
            double num2 = double.Parse(nums[1]);
            double num3 = double.Parse(nums[2]);
            double pi = 3.14159;

            // Área do triangulo
            double areaTriangulo = (num1 * num3) / 2;
            double areaCirculo = pi * (num3 * num3);
            double areaTrapezio = ((num1 + num2)*num3) / 2;
            double areaQuadrado = num2 * num2;
            double areaRetangulo = num1 * num2;

            Console.WriteLine($"Triangulo: {areaTriangulo}");
            Console.WriteLine($"Circulo: {areaCirculo}");
            Console.WriteLine($"Trapezio: {areaTrapezio}");
            Console.WriteLine($"Quadrado: {areaQuadrado}");
            Console.WriteLine($"Retangulo: {areaRetangulo}");
        }
    }
}
