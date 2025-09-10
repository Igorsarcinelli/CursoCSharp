using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes;
internal class ColecoesQueue
{
    public static void Executar()
    {
        var fila = new Queue<string>();

        fila.Enqueue("Fulano");
        fila.Enqueue("Sicrano");
        fila.Enqueue("Beltrano");
        fila.Enqueue("Rachando");

        // O proximo elemento a sair da fila, mas não vai exclui-lo
        Console.WriteLine(fila.Peek());
        Console.WriteLine(fila.Count);
        Console.WriteLine("=========================== \n");
        Console.WriteLine(fila.Dequeue());
        Console.WriteLine(fila.Count);
        Console.WriteLine(fila.Contains("Sicrano"));

        foreach (var pessoa in fila)
        {
            Console.WriteLine(pessoa);
        }
    }
}
