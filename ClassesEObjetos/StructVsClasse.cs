using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos;
internal class StructVsClasse
{
    public struct SPonto
    {
        public int X;
        public int Y;
    }

    public class CPonto
    {
        public int X;
        public int Y;
    }

    public static void Executar()
    {   
        SPonto ponto1 = new SPonto { X = 1, Y = 2};
        SPonto copiaPonto1 = ponto1;
        ponto1.X = 3;
        // São 2 valores independetes, eu fiz uma copia do ponto 1 e depois modifiquei para 3, o valor não muda

        Console.WriteLine("Ponto1 X:{0}", ponto1.X);
        Console.WriteLine("Copia ponto 1: {0}", copiaPonto1.X);


        // A atribuição é feita por referencia, ao mudar a referencia a copia tambem muda
        CPonto ponto2 = new CPonto { X = 1, Y = 2};
        CPonto copiaPonto2 = ponto2;
        ponto2.X = 3;
        Console.WriteLine("Ponto 2:{0}", ponto2.X);
        Console.WriteLine("Copia Ponto 2:{0}", copiaPonto2.X);

        
    }
                
}
