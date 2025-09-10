using System;
using System.Collections.Generic;

namespace CursoCSharp.CursoCSharpCompleto;

internal class ProjetoFarmacia
{
    struct DadosDeEstoque
    {
        public int IdRemedio;
        public string NomeDoRemedio;
        public double ValorUnd;
    }

    public static void Executar()
    {
        Console.WriteLine("Informe o que você é: \n 1-Estoquista \n 2-Atendente");
        int.TryParse(Console.ReadLine(), out int opcao);

        Console.Clear();

        var listaDeEstoque = new List<DadosDeEstoque>();

        switch (opcao)
        {
            case 1:
                Console.WriteLine("================ESTOQUISTA================");

                string opcaoProduto;
                int contadorIDProduto = 0;
                do
                {
                    Console.WriteLine("Deseja cadastrar um novo produto? S/N");
                    opcaoProduto = (Console.ReadLine() ?? "").Trim().ToUpper();

                    if (opcaoProduto == "S")
                    {
                        var item = new DadosDeEstoque();

                        contadorIDProduto ++;
                        item.IdRemedio = contadorIDProduto;

                        Console.Write("Informe o nome do produto: ");
                        item.NomeDoRemedio = Console.ReadLine() ?? string.Empty;

                        Console.Write("Informe o valor por unidade: ");
                        item.ValorUnd = Convert.ToDouble(Console.ReadLine());

                        listaDeEstoque.Add(item);
                        Console.WriteLine("Produto cadastrado com sucesso!\n");
                    }

                } while (opcaoProduto == "S");

                break;

            case 2:
                Console.WriteLine("================ATENDENTE================");
                // aqui você pode implementar a lógica do atendente (consulta à listaDeEstoque etc.)
                break;

            default:
                Console.WriteLine("Opção inválida.");
                break;
        }
    }
}

