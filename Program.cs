using System;
using System.Collections.Generic;

using CursoCSharp.Fundamentos;
using CursoCSharp.EstruturaDeControle;
using CursoCSharp.MeusExercicios;
using CursoCSharp.ClassesEObjetos;
using static CursoCSharp.ClassesEObjetos.CalculadoraEstatica;

namespace CursoCSharp
{
    class Progam
    {
        static void Main(string[] args)
        {
            var central = new CentralDeExercicios(new Dictionary<string, Action>() {
                //Fundamentos
                {"Primeiro Programa - Fundamrntos", PrimeiroPrograma.Executar},
                {"Comentários Programa - Fundamentos", Comentarios.Executar},
                {"Variáveis e Constantes - Fundamentos", VariaveisEConstantes.Executar},
                {"Inferência - Fundamentos", Inferencia.Executar},
                {"Interpolação - Fundamentos", Interpolação.Executar},
                {"Notação Ponto - Fundamentos", NotacaoPonto.Executar},
                {"Lendo dados - Fundamentos", LendoDados.Executar},
                {"Formatando Número - Fundamentos", FormatandoNumero.Executar},
                {"Conversões - Fundamentos", Conversoes.Executar},
                {"Operadores Aritiméticos - Fundamentos", OperadoresAritmeticos.Executar},
                {"Operadores Relacionais - Fundamentos", OperadoresRelacionais.Executar},
                {"Operadores Lógicos - Fundamentos", OperadoresLogicos.Executar},
                {"Operadores de Atribuição - Fundamentos", OperadoresDeAtribuicao.Executar},
                //Estruturas de Controle
                {"Estrutura If - Estruturas de Controle", EstruturaIF.Executar},
                {"Estruturas If/Else - Estruturas de Controle", EstruturaIFEElse.Executar},
                {"Estruturas If/Else if - Estruturas de Controle", EstruturaIfElseIF.Executar},
                {"Switch - Estruturas de Controle", Switch.Executar},
                {"While - Estruturas de Controle", While.Executar},
                {"Do While - Estruturas de Controle", DoWhile.Executar},
                {"Estrutura FOR - Estruturas de Controle", For.Executar},
                {"Estrutura Break - Estruturas de Controle", Break.Executar},               
                // Meus exercicios 
                {"Calculo de Estoque médio - Meus Exercícios", EstoqueMedio.Executar},
                {"Calculo Comissão de Vendedores - Meus Exercícios", ComissaoVendedores.Executar},
                {"Três Numeros Inteiros em ordem - Meus Exercícios", TresNumInteirosOrdem.Executar},
                {"Calculadora - Meus Exercícios", Calculadora.Executar},
                {"Calculadora usando classes e métodos - Meus Exercícios", CalculadoraUsandoClasses.Executar},
                // Classes e Objetos
                {"Membros - Classes e Objetos", Membros.Executar },
                {"Construtores - Classes e Objetos", Construtores.Executar},
                {"Métodos com retorno - Classes e Objetos", MetodosComRetorno.Executar},
                {"Métodos estáticos - Classes e Objetos", MetodosEstaticos.Executar},
                {"Atributos estáticos - Classes e Objetos", AtributosEstaticos.Executar},
                {"Desafio atributos - Classes e Objetos", DesafioAtributos.Executar}

            });
            central.SelecionarEExecutar();
        }
    }
}