using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MeusExercicios
{
    internal class ExercicioSenha
    {
        public static void Executar()
        {
            Console.WriteLine("Informe sua senha: ");
            int senha = int.Parse(Console.ReadLine());

            while (senha != 2002){
                Console.WriteLine("Senha invalida");

                Console.WriteLine("Informe sua senha: ");
                senha = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Acesso Permitido");

        }
    }
}
