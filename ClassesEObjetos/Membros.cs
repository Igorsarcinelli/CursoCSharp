using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.ClassesEObjetos {
    public class Membros {

        public static void Executar()
        {
            Carro onix = new Carro();

            onix.Nome = "Ônix";
            onix.Marca = "Chevrolet";
            onix.TipoDeCarro = "Hatch";
            onix.AnoDoCarro = 2015;

            onix.ApresentarNoConsole();
        }
    }
}
