using System;
using System.Collections.Generic;
using System.Linq; // Necessário para usar o .Max() e filtros mais fáceis

namespace AlunoNotas
{
    public class Aluno
    {
        public string Nome { get; set; } = string.Empty;
        public double Nota { get; set; }
    }

    class Program
    {
        static void Main()
        {
            // 1. PREPARAÇÃO
            List<Aluno> listaAlunos = new List<Aluno>();
            double somaNotas = 0;

            // 2. ENTRADA DE DADOS (LOOP)
            for (int i = 0; i < 5; i++)
            {
                Aluno alunoNovo = new Aluno();

                Console.Write($"Digite o nome do {i + 1}º aluno: ");
                alunoNovo.Nome = Console.ReadLine() ?? "";

                Console.Write($"Digite a nota de {alunoNovo.Nome}: ");
                string entradaNota = Console.ReadLine() ?? "0";
                alunoNovo.Nota = double.Parse(entradaNota);

                // Acumulando para a média e guardando na lista
                somaNotas += alunoNovo.Nota;
                listaAlunos.Add(alunoNovo);
                
                Console.WriteLine("---");
            }

            // 3. PROCESSAMENTO
            double mediaTurma = somaNotas / listaAlunos.Count;

            // Encontrando a maior nota (Lógica de Engenheiro)
            Aluno alunoDestaque = listaAlunos[0]; 
            foreach (var aluno in listaAlunos)
            {
                if (aluno.Nota > alunoDestaque.Nota)
                {
                    alunoDestaque = aluno;
                }
            }

            // 4. SAÍDA (RESULTADOS)
            Console.Clear();
            Console.WriteLine("===== RELATÓRIO FINAL =====");
            Console.WriteLine($"Média Geral da Turma: {mediaTurma:F2}");
            Console.WriteLine($"Aluno Destaque: {alunoDestaque.Nome} (Nota: {alunoDestaque.Nota})");
            
            Console.WriteLine("\nLista de Aprovados:");
            foreach (var aluno in listaAlunos)
            {
                if (aluno.Nota >= 7)
                {
                    Console.WriteLine($"- {aluno.Nome} (Nota: {aluno.Nota})");
                }
            }
        }
    }
}
