/*Gestor de Equipe (Team Manager)
O Problema: Você precisa gerenciar os dados básicos de uma equipe de trabalho.
A Classe: Crie uma classe chamada Funcionario com as propriedades:
Nome (string)
Salario (double)
O Cadastro: Peça ao usuário para cadastrar 4 funcionários.
O Relatório: Ao final, o programa deve mostrar:
O Custo Total da folha de pagamento (soma de todos os salários).
A Média Salarial da equipe.
O nome do funcionário que tem o Maior Salário.
Uma lista com o nome apenas dos funcionários que ganham acima da média calculada.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace GestorEquipe
{
    public class Funcionario
    {
        public string Nome { get; set; } = string.Empty;
        public double Salario { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Funcionario> listaFuncionarios = new List<Funcionario>();
            double somaFolhaPagamento = 0;

            for (int i = 0; i < 4; i++)
            {
                Funcionario funcionarioNovo = new Funcionario();

                Console.Write($"Digite o nome do {i + 1}º funcionário: ");
                funcionarioNovo.Nome = Console.ReadLine() ?? "";

                Console.Write($"Digite o salário do {funcionarioNovo.Nome}: ");
                string entradaSalario = Console.ReadLine() ?? "0";
                funcionarioNovo.Salario = double.Parse(entradaSalario);

                somaFolhaPagamento += funcionarioNovo.Salario;
                listaFuncionarios.Add(funcionarioNovo);
            }

            double mediaEquipe = somaFolhaPagamento / listaFuncionarios.Count;

            Funcionario funcionarioDestaque = listaFuncionarios[0];
            foreach (var funcionario in listaFuncionarios)
            {
                if (funcionario.Salario > funcionarioDestaque.Salario)
                {
                    funcionarioDestaque = funcionario;
                }
            }

            Console.Clear();
            Console.WriteLine("===== Relatório Final =====");
            Console.WriteLine($"Média geral da equipe: {mediaEquipe}");
            Console.WriteLine($"Funcionário do mês: {funcionarioDestaque.Nome} (Salario: {funcionarioDestaque.Salario}");

            Console.WriteLine("\nLista de funcionários bonificados:");
            foreach (var funcionario in listaFuncionarios)
            {
                if (funcionario.Salario > mediaEquipe)
                {
                    Console.WriteLine($"- {funcionario.Nome} (Salário: {funcionario.Salario})");
                }
            }
        }
    }
}
