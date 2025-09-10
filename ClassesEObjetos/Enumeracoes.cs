using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos;

public enum DiaDaSemana
{
    Segunda, Terca, Quarta, Quinta, Sexta, Sabado, Domingo
};

public class Calendario
{
    public int DiaDoMes;
    public DiaDaSemana DiaSemana;
}

internal class Enumeracoes
{
    public static void Executar()
    {
        var DataDoMes = new Calendario();
        DataDoMes.DiaDoMes = 23;
        DataDoMes.DiaSemana = DiaDaSemana.Terca;

        Console.WriteLine("{0} é {1}!", DataDoMes.DiaDoMes, DataDoMes.DiaSemana);
    }
}
