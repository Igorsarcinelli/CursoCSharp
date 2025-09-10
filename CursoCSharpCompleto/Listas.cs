using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.CursoCSharpCompleto;
internal class Listas
{
    public static void Executar()
    {
        // Criar uma lista
        List<string> ListaDeNomes = new List<string>();

        // Adicionar elementos na lista
        ListaDeNomes.Add("Igor");
        ListaDeNomes.Add("João");
        ListaDeNomes.Add("Pedro");
        ListaDeNomes.Add("Jonas");
        ListaDeNomes.Add("Batista");

        // Removendo elementos
        ListaDeNomes.Remove("Jonas");

        //Remover elemento em posição específica
        ListaDeNomes.RemoveAt(2);

        

        List<string> ListaDeNomes2 = new List<string>();
        ListaDeNomes2.Add("Igor");
        ListaDeNomes2.Add("João");
        ListaDeNomes2.Add("Pedro");
        ListaDeNomes2.Add("Jonas");
        ListaDeNomes2.Add("Batista");


        //Remover range de elementos
        // o primeiro elemento siginifica que é a partir dele e o segundo a quantidade de elementos a partir dele
        ListaDeNomes2.RemoveRange(3, 2);

        // Descobrir o numero de elementos
        Console.WriteLine(ListaDeNomes2.Count);

        // Concatenando Listas

        List<string> Lista1 = new List<string>();
        Lista1.Add("Igor");
        Lista1.Add("João");
        Lista1.Add("Pedro");
        Lista1.Add("Jonas");
        Lista1.Add("Batista");

        List<string> Lista2 = new List<string>();
        Lista2.Add("Lucas");
        Lista2.Add("Beatriz");
        Lista2.Add("Beraldo");
        Lista2.Add("Ronaldo");
        Lista2.Add("fenomento");

        List<string> ListaConcatenada = Lista2.Concat(Lista2).ToList();

        // Buscar um determinado valor
        bool contemNome = ListaConcatenada.Contains("Beraldo");
        bool contemManuela = ListaConcatenada.Contains("Manuela");
        Console.WriteLine("A lista contem Beraldo?");
        Console.WriteLine(contemNome);
        Console.WriteLine("A lista contem manuela?");
        Console.WriteLine(contemManuela);

        //Descobrir indice de um elemento
        int indice = ListaConcatenada.IndexOf("Igor");
        Console.WriteLine("O indice do nome Igor é: " + indice);

        // Operador Where
        List<string> ListaWhere = ListaConcatenada.Where(x => x.StartsWith("B")).ToList();

        foreach (string nomes in ListaWhere)
        {
            Console.WriteLine(nomes);
        }



        //imprimir elementos na lista
        foreach (string nome in ListaDeNomes)
        {
            Console.WriteLine(nome);
        }
        Console.WriteLine("===============================================");

        //imprimir elementos na lista
        foreach (string nome in ListaDeNomes2)
        {
            Console.WriteLine(nome);
        }
        Console.WriteLine("===============================================");

        //imprimir elementos na lista
        foreach (string nome in ListaConcatenada)
        {
            Console.WriteLine(nome);
        }
    }

}
