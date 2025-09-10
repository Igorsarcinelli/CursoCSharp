using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.Fundamentos
{
    internal class EstudoDeArray
    {
        public void Executar()
        {
            // Array de 1 dimensão
            int[] meuArray1 = new int[3];
            meuArray1[0] = 1;
            meuArray1[1] = 10;
            meuArray1[2] = 30;

            Console.WriteLine(meuArray1[0]);
            Console.WriteLine(meuArray1[1]);
            Console.WriteLine(meuArray1[2]);

            // outras maneiras de criar Array
            int[] meuArray2 = { 10, 100, 300 };
            Console.WriteLine(meuArray2[0]);
            Console.WriteLine(meuArray2[1]);
            Console.WriteLine(meuArray2[2]);

            // para saber o numero de elementos do array
            int tamanho1 = meuArray1.GetLength(0);
            Console.WriteLine("O tamanho do meu array possui" + tamanho1);
        }
    }
}
