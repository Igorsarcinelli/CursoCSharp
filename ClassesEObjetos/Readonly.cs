using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos;

public class Cliente
{
    public string Nome;
    readonly DateTime Nascimento; // Readonly é como se fosse um const mas a partir da primeira vez que é digitada

    public Cliente(string nome, DateTime nascimento)
    {
        Nome = nome;
        Nascimento = nascimento;
    }
    public string GetDataDeNascimento()
    {
        return String.Format("{0}/{1}/{2]", Nascimento.Day, Nascimento.Month, Nascimento.Year);
    }
}


internal class Readonly
{
    public static void Executar()
    {   // static não precisa criar objeto para a função funcionar
        var novoCliente = new Cliente("Ana Silva", new DateTime(1987, 5, 23));
        Console.Write(novoCliente.Nome);
        Console.WriteLine(novoCliente.GetDataDeNascimento());
    }
}
