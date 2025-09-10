using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MeusExercicios
{
    internal class ComissaoVendedores
    {
        public static void Executar()
        {
            Console.WriteLine("Informe o nome do vendedor: ");
            string nomeVendedor = Console.ReadLine();
            Console.WriteLine("Informe o código da peça: ");
            string codigoPeça = Console.ReadLine();
            Console.WriteLine("Informe o preço por unidade: ");
            string precoUnid = Console.ReadLine();
            double.TryParse(precoUnid, out double precoUnitario);
            Console.WriteLine("Informe a quantidade de peças vendidas");
            string qtdVenda = Console.ReadLine();
            int.TryParse(qtdVenda, out int qtdVendida);

            Console.WriteLine($"{nomeVendedor} vendeu {qtdVendida} peças com o código {codigoPeça} e preço por unidade de {precoUnitario}");
        }
    }
}
