using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.EstruturaDeControle
{
    internal class While
    {
        public static void Executar()
        {
            double valorTotal = 0;
            while (true)
            {
                Console.WriteLine("Deseja informar um item? sim / nao ");
                string resposta = Console.ReadLine();


                if (resposta == "sim")
                {
                    Console.WriteLine("Informe a quantidade de itens: ");
                    int.TryParse(Console.ReadLine(), out int qtdItens);
                    Console.WriteLine("Informe o valor unitário: ");
                    double.TryParse(Console.ReadLine(), out double valorUnd);

                    double valorCompra = qtdItens * valorUnd;
                    valorTotal += valorCompra;
                    continue;
                }
                else
                {
                    break;
                }
            }

            if (valorTotal > 200)
            {
                valorTotal = valorTotal * 0.9;
                Console.WriteLine("O valor total da compra foi: {0}", valorTotal);
            }
            else
            {
                Console.WriteLine("O valor total da compra foi: {0}", valorTotal);
            }
        }
    }
}
