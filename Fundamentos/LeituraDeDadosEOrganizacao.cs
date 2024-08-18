using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Para usar o CultureInfo e mudar o numero de , para .
using System.Globalization;

namespace CursoCSharp.Fundamentos
{
    internal class LeituraDeDadosEOrganizacao
    {
        public static void Executar()
        {
            //Esse método não é correto pois o usuário pode informar numero errados
            int n1 = int.Parse(Console.ReadLine());

            char ch = char.Parse(Console.ReadLine());

            double n2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        }
    }
}
