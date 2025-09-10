using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.MeusExercicios;
internal class LoginConsole
{
    public static void Executar()
    {
        Console.WriteLine("Informe seu nome de usuário: ");
        string usuario = Console.ReadLine();

        Console.WriteLine("Informe sua senha: ");
        string senha = "";

        while (true)
        {
            ConsoleKeyInfo tecla = Console.ReadKey(true);
            if (tecla.Key == ConsoleKey.Enter)
                break;
            else
            {
                senha += tecla.KeyChar;
            }
        }

        if (usuario == "Igor" && senha == "1234")
        {
            Console.WriteLine("Usuario logado");
        }
        else
        {
            Console.WriteLine("Usuario ou senha incorreto");
        }
    }
}
