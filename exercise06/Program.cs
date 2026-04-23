/*Wallet-Control (Gerenciador de Investimentos) 💰
O Problema: Você precisa criar um sistema para consolidar a carteira de investimentos de um cliente.
A Classe: Investimento com:
NomeAtivo (string) -> Ex: "Bitcoin", "Ações Apple".
ValorInvestido (double).
O Cadastro: O programa deve pedir para cadastrar 3 investimentos.
O Relatório (A "Response" Bonitinha):
Patrimônio Total: (Soma de todos os valores usando +=).
Média por Ativo: (Valor total dividido pela quantidade).
Ativo Principal: Nome do ativo com o maior valor investido.
Lista High-Ticket: Uma lista com os ativos que possuem valor acima de R$ 1.000,00.*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace WalletControl
{
    public class Investimento
    {
        public string NomeAtivo { get; set; } = string.Empty;
        public double ValorInvestido { get; set; }
    }

    public class Program
    {
        static void Main()
        {
            List<Investimento> listaInvestimento = new List<Investimento>();
            double patrimonioTotal = 0;

            for (int i = 0; i < 3; i++)
            {
                Investimento investimentoNovo = new Investimento();

                Console.Write($"Qual o {i + 1}º ativo: ");
                investimentoNovo.NomeAtivo = Console.ReadLine() ?? "";

                Console.Write($"Qual o Valor do {investimentoNovo.NomeAtivo} (em R$): ");
                string entrada = Console.ReadLine() ?? "0";
                investimentoNovo.ValorInvestido = double.Parse(entrada);

                listaInvestimento.Add(investimentoNovo);

                patrimonioTotal += investimentoNovo.ValorInvestido;
            }

            double mediaInvestido = patrimonioTotal / listaInvestimento.Count;
            Investimento ativoPrincipal = listaInvestimento[0];

            foreach (var investimento in listaInvestimento)
            {
                if (investimento.ValorInvestido > ativoPrincipal.ValorInvestido)
                {
                    ativoPrincipal = investimento;
                }
            }

            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("             WALLET REPORT              ");
            Console.WriteLine("========================================");

            Console.WriteLine($"Patrimônio total: {patrimonioTotal:C} ");
            Console.WriteLine($"Média por ativo: {mediaInvestido:C} ");
            Console.WriteLine($"Ativo principal: {ativoPrincipal.NomeAtivo}");

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("           LISTA HIGH-TICKET             ");
            Console.WriteLine("----------------------------------------");

            foreach (var investimento in listaInvestimento)
            {
                if (investimento.ValorInvestido > 1000)
                {
                    Console.WriteLine($"- {investimento.NomeAtivo, -15} | {investimento.ValorInvestido:C} ");
                }
            }
        }
    }
}


