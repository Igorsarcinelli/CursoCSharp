using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos;
internal class VariavelDateTime
{
    public static void Executar()
    {
        DateTime data = new DateTime(2020,09,26);
        DateTime dataHora = new DateTime(2020, 09, 26, 14, 12, 45);

        // Podemos acessar cada valor da data separadamente
        Console.WriteLine("Ano: {0}", dataHora.Year);
        Console.WriteLine("Mês: {0}", dataHora.Month);
        Console.WriteLine("Dia: {0}", dataHora.Day);
        Console.WriteLine("Dia: {0}", dataHora.DayOfWeek);
        Console.WriteLine("Dia: {0}", dataHora.Hour);
        Console.WriteLine("Dia: {0}", dataHora.Minute);
        Console.WriteLine("Dia: {0}", dataHora.Second);
        Console.WriteLine(dataHora.ToString());

    }
}
