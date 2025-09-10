using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos
{
    class Carro
    {
        public string Nome;
        public string Marca;
        public string TipoDeCarro;
        public int AnoDoCarro;

        public string Apresentar()
        {
            return string.Format($"O meu carro é um {Nome} da {Marca}, um carro {TipoDeCarro} de {AnoDoCarro}");
        }

        public void ApresentarNoConsole()
        {
            Console.WriteLine(Apresentar());    
        }
    } 
}
