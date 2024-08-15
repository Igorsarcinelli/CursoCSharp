using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class OperadoresRelacionais
    {
        public static void Executar()
        {
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine($"Nota invalida? {nota > 10.0}");
            Console.WriteLine($"Nota valida? {nota < 10.0}");
            Console.WriteLine($"Perfeito? {nota == 10.0}");
            Console.WriteLine($"Tem como melhorar? {nota == notaDeCorte}");



        }
    }
}
