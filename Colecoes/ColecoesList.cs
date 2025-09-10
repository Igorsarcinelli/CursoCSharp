using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Colecoes;
internal class ColecoesList
{
    public class Produto
    {
        public string Nome;
        public double Preco;
    
        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }

    public static void Executar()
    {
        var livro = new Produto("Game of Thrones", 49.9);

        var carrinho = new List<Produto>();
        carrinho.Add(livro);

        var combo = new List<Produto>
        {
            new Produto("Camisa", 23.90),
            new Produto("Tenis", 345.80),
            new Produto("Poster", 12.40)
        };

        // AddRange para adicionar todos os elementos
        carrinho.AddRange(combo);

        foreach (var item in carrinho)
        {
            Console.WriteLine("Item: {0} / Valor: {1} \n", item.Nome, item.Preco);
        }

    }
}
