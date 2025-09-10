using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.CursoCSharpCompleto;
internal class UsoDeStruct
{
    struct DadosCadastrais
    {
        public string Nome;
        public string NomeDaRua;
        public DateTime DataDeNascimento;
    }
    public static void Executar()
    {
        DadosCadastrais cadastroJoao;

        cadastroJoao.Nome = "João";
        cadastroJoao.NomeDaRua = "Palmeiras";
        cadastroJoao.DataDeNascimento = Convert.ToDateTime("21/12/2002");

        Console.WriteLine(cadastroJoao.Nome);
    }
}
