using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos;

public class Moto
    {
    private string Nome;
    private int Ano;
    private int Cilindrada;

    public Moto(string nome, int ano, int cilindrada)
    {
        Nome = nome;
        Ano = ano;
        Cilindrada = cilindrada;
    }

    public Moto()
    {
    }

    // Como os atributos estão privados não posso acessa-los automaticamente por isso fazer o Get e Set
    public string GetNome()
    {
        return Nome;
    }

    public void SetNome(string nome)
    {
        Nome = nome;
    }

    public int GetAno()
    {
        return Ano;
    }

    public void SetAno(int ano)
    {
        Ano = ano;
    }

    public int GetCilindrada()
    {
        return Cilindrada;
    }

    public void SetCilindrada(int cilindrada)
    {
        Cilindrada = cilindrada;
    }


    }

internal class GetSet
    {
    public static void Executar()
    {
        var moto1 = new Moto("C200", 2002, 233);

        Console.WriteLine(moto1.GetNome);
        Console.WriteLine(moto1.GetAno);
        Console.WriteLine(moto1.GetCilindrada);
    }
    }
