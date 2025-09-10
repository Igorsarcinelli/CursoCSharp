using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos
{
        public class Produto
        {
            public string Nome;
            public double Preco;
            // ao passar public static double Desconto 
            //significa que ele será assim para todos
            public double Desconto = 0.1;

            public Produto(string nome, double preco, double desconto)
            {
                Nome = nome;
                Preco = preco;
                Desconto = desconto; 
            }

            public Produto()
            {

            }

            public double CalcularDesconto()
            {
                return Preco - Preco * Desconto;
            }
        }

        internal class AtributosEstaticos
        {
        public static void Executar()
        {
            var produto1 = new Produto("Caneta", 3.2, 0.1);

            var produto2 = new Produto()
            {
                Nome = "Lápis",
                Preco = 4.3,
                Desconto = 0.1
            };

            Console.WriteLine(produto1.CalcularDesconto());
            Console.WriteLine();
            Console.WriteLine(produto2.CalcularDesconto());
        }

        }
    }

