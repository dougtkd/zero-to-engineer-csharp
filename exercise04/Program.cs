/*Controle de Frota (Fleet Control)
O Problema: Você trabalha em uma empresa de logística e precisa organizar os dados de alguns veículos da frota.
A Classe: Crie uma classe chamada Veiculo com as propriedades:
Modelo (string)
Quilometragem (double)
O Cadastro: Peça ao usuário para cadastrar 5 veículos.
O Relatório: Ao final, o programa deve mostrar:
A Quilometragem Total percorrida por toda a frota (soma de todas as quilometragens).
A Média de Quilometragem dos veículos.
O modelo do veículo Mais Rodado (maior quilometragem).
Uma lista com os modelos dos veículos "Seminovos" (aqueles que têm quilometragem abaixo de 20.000).*/

using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleFrota
{
    public class Veiculo
    {
        public string Modelo {get; set; } = string.Empty;
        public double Quilometragem {get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Veiculo> listVeiculo = new List<Veiculo>();
            double somaQuilometragem = 0;

            for (int i = 0; i < 5; i++)
            {
                Veiculo veiculoNovo = new Veiculo();

                Console.Write($"Digite o modelo do {i + 1}º veículo: ");
                veiculoNovo.Modelo = Console.ReadLine() ?? "";

                Console.Write($"Digite a quilometragem de {veiculoNovo.Modelo}: ");
                string entrada = Console.ReadLine() ?? "0";
                veiculoNovo.Quilometragem = double.Parse(entrada);

                somaQuilometragem += veiculoNovo.Quilometragem;
                listVeiculo.Add(veiculoNovo);

                Console.WriteLine("---");
            }

            double mediaFrota = somaQuilometragem / 5;

            Veiculo veiculoDestaque = listVeiculo[0];
            foreach (var veiculo in listVeiculo)
            {
                if (veiculo.Quilometragem > veiculoDestaque.Quilometragem)
                {
                    veiculoDestaque = veiculo;
                }
            }

            Console.Clear();
            Console.WriteLine("===== Relatório Final =====");
            Console.WriteLine($"Média geral da Frota: {mediaFrota}");
            Console.WriteLine($"Veículo mais rápido: {veiculoDestaque.Modelo}");

            Console.WriteLine("\nLista de veículos velozes:");
            foreach (var veiculo in listVeiculo)
            {
                if (veiculo.Quilometragem > mediaFrota)
                {
                    Console.WriteLine($"- {veiculo.Modelo} (Quilometragem: {veiculo.Quilometragem})");
                }
            }
        }
    }
}


