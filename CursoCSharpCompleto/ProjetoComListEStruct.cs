using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.CursoCSharpCompleto;
internal class ProjetoComListEStruct
{
    struct DadosCadastrais
    {
        public string Nome;
        public string Sobrenome;
        public int Idade;
        public string Naturalidade;
    }
    public static void Executar()
    {
        List<DadosCadastrais> ListaDeCadastros = new List<DadosCadastrais> ();

        string opcao;
        do
        {
            Console.WriteLine("Digite C para cadastrar e S para sair: ");
            opcao = Console.ReadKey(true).KeyChar.ToString().ToLower();
            if (opcao == "c")
            {
                DadosCadastrais dadosDeCadastro;
                Console.WriteLine("Digite o nome:");
                dadosDeCadastro.Nome = Console.ReadLine();
                Console.WriteLine("Digite o sobrenome:");
                dadosDeCadastro.Sobrenome = Console.ReadLine();
                Console.WriteLine("Digite sua idade:");
                dadosDeCadastro.Idade = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Informe sua naturalidade");
                dadosDeCadastro.Naturalidade = Console.ReadLine();
                ListaDeCadastros.Add(dadosDeCadastro);
                Console.Clear();
            }
            else if (opcao == "S")
            {
                Console.WriteLine("Saindo");
            }
            else
            {
                Console.WriteLine("Opção invalida");
            }

        } while (opcao != "s");
        Console.WriteLine("Pressione qualquer tecla para sair");
        Console.ReadKey();
    }
}
