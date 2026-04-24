/*Tech-Events (Gestão de Inscrições)
O Problema: Você está organizando um evento de tecnologia e precisa gerenciar os participantes.
A Classe: Participante com as propriedades:
Nome (string)
Idade (int)
O Cadastro: Peça ao usuário para cadastrar 3 participantes.
O Relatório (Response Bonitinha):
Total de Inscritos: Quantidade na lista.
Média de Idade: (Soma das idades / total).
Participante mais Experiente: Nome de quem tem a maior idade.
Lista VIP: Mostrar apenas quem tem 30 anos ou mais*/

using System;
using System.Collections.Generic;

namespace TechEvents
{
    public class Participante
    {
        public string Name { get; set; } = string.Empty;
        public int Idade { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Participante> lista = new List<Participante>();

            for (int i = 0; i < 3; i++)
            {
                Participante p = new Participante();

                Console.Write($"Nome do {i + 1}º participante: ");
                p.Name = Console.ReadLine() ?? "";

                Console.Write($"Idade de {p.Name}: ");
                string entrada = Console.ReadLine() ?? "";

                bool conseguiuConverter = int.TryParse(entrada, out int idadeConvertida);

                if (conseguiuConverter)
                {
                    p.Idade = idadeConvertida;
                }
                else
                {
                    Console.WriteLine("Idade inválida! Usando 0 por segurança!");
                    p.Idade = 0;
                }

                lista.Add(p);
            }

            Console.WriteLine("\n--- Inscritos ---");
            foreach (var part in lista)
            {
                Console.WriteLine($"{part.Name} - {part.Idade} anos");
            }
        }
    }
}

