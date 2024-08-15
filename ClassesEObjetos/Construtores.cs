using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos
{
    class Carro
    {
        public string Modelo;
        public string Fabricante;
        public int Ano;

        public Carro(string modelo, string fabricante, int ano)
        {
            Modelo = modelo;
            Fabricante = fabricante;
            Ano = ano;
        }
        public Carro()
        {
        }
    }
    public class Construtores
    {
        public static void Executar()
        {
            var Carro1 = new Carro();
            Carro1.Modelo = "HB20";
            Carro1.Fabricante = "Hyunday";
            Carro1.Ano = 2024;
            Console.WriteLine($"O carro {Carro1.Modelo} é da fabricante {Carro1.Fabricante} do ano de {Carro1.Ano}");

            var Carro2 = new Carro("Ka","ford",2018);
            Console.WriteLine($"{Carro2.Ano} {Carro2.Modelo} {Carro2.Fabricante}");

            var Carro3 = new Carro()
            {
                Fabricante = "Fiat",
                Modelo = "Uno",
                Ano = 2023
            };
            Console.WriteLine($"{Carro3.Ano} {Carro3.Modelo} {Carro3.Fabricante}");
        }
    }
}
