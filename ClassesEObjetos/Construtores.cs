using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEObjetos;
public class Construtores
{
    class Pessoa
    {   // essa classe possui 3 atribuitos
        public string Nome; // Atribuito 01
        public string Sexo; // Atributo 02
        public int Idade; // Atributo 03

        // Construtor 01
        public Pessoa(string nome, string sexo, int idade)
        {
            Nome = nome;
            Sexo = sexo;
            Idade = idade;
        }

        // Construtor 02
        public Pessoa()
        {

        }
    }
    public static void Executar()
    {   
        // Usado o constutor 02
        var igor = new Pessoa();
        igor.Nome = "Igor";
        igor.Sexo = "Masculino";
        igor.Idade = 22;

        int anoDeNascimento = igor.Idade - 2025;
        Console.WriteLine($"O nome dele é {igor.Nome}, é do sexo {igor.Sexo}, tem {igor.Idade} nasceu em {anoDeNascimento}");
        
        // ==============================================================================================================

        // Construtor 01
        var thais = new Pessoa("Thaís", "Feminino", 22);
        Console.WriteLine($"O nome dele é {thais.Nome}, é do sexo {thais.Sexo}, tem {thais.Idade}");
    }
}
