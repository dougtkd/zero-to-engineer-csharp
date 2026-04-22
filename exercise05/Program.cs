/*Cine-Manager (Sistema de Filmes)
O Problema: Organizar os dados de um streaming.
A Classe: Filme com as propriedades:
Titulo (string)
Duracao (double) -> Em minutos
O Cadastro: Peça para cadastrar 3 filmes.
O Relatório:
Tempo Total somado.
Média de Duração.
O título do filme Mais Longo.
Lista de filmes Épicos (mais de 120 min). */

using System;
using System.Collections.Generic;
using System.Linq;

namespace CineManager
{
    public class Filme
    {
        public string Titulo { get; set; } = string.Empty;
        public double Duracao { get; set; }
    }

    public class Program
    {
        static void Main()
        {
            List<Filme> filmeList = new List<Filme>();
            double tempoTotal = 0;

            for (int i = 0; i < 3; i++)
            {
                Filme filmeNovo = new Filme();

                Console.Write($"Qual o {i + 1}º filme: ");
                filmeNovo.Titulo = Console.ReadLine() ?? "";

                Console.Write($"Qual o tempo do {filmeNovo.Titulo} (em min): ");
                string entrada = Console.ReadLine() ?? "0";
                filmeNovo.Duracao = double.Parse(entrada);

                filmeList.Add(filmeNovo);

                tempoTotal += filmeNovo.Duracao;
            }

            double mediaDuracao = tempoTotal / filmeList.Count;
            Filme filmeMaisLongo = filmeList[0];

            foreach (var filme in filmeList)
            {
                if (filme.Duracao > filmeMaisLongo.Duracao)
                {
                    filmeMaisLongo = filme;
                }
            }

            Console.Clear();
            Console.WriteLine("========================================");
            Console.WriteLine("          CINE-MANAGER REPORT           ");
            Console.WriteLine("========================================");

            Console.WriteLine($"Tempo total dos filmes: {tempoTotal} min");
            Console.WriteLine($"Média de duração:       {mediaDuracao:F2} min");
            Console.WriteLine($"O filme mais longo é: {filmeMaisLongo.Titulo}");

            Console.WriteLine("\n----------------------------------------");
            Console.WriteLine("       LISTA DE FILMES ÉPICOS           ");
            Console.WriteLine("       (Duração > 450 minutos)          ");
            Console.WriteLine("----------------------------------------");

            foreach (var filme in filmeList)
            {
                if (filme.Duracao > 450)
                {
                    Console.WriteLine($"- {filme.Titulo, -20} | {filme.Duracao} min");
                }
            }        
        }
    }
}

