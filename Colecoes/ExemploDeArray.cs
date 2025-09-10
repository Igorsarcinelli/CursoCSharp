using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CursoCSharp.Colecoes
{
    class ExemploDeArray
    {
        public static void Executar()
        {   
            // É uma estrutura homogenea (apenas string, apenas int, o que voce setar)
            // É uma estrutura estática
            string[] alunos = new string[5];
            alunos[0] = "João";
            alunos[1] = "Jonas";
            alunos[2] = "Luiz";
            alunos[3] = "Pedro";
            alunos[4] = "Jair";

            foreach (var aluno in alunos)
            {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 5.2, 5.4, 5.3, 7.5, 7.8 };

            foreach (var nota in notas)
            {
                somatorio += nota;
            }

            double media = somatorio / (notas.Length);
            Console.WriteLine(media);
        }
    }
}

