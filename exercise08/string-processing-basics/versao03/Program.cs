using System;
using System.Collections.Generic;

namespace ExercicioCsharp
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Digite a palavra: ");
            string? palavra = Console.ReadLine();

            if (string.IsNullOrEmpty(palavra))
            {
                Console.WriteLine("palavra inválida!");
                return;
            }

            string removerEspaco = palavra.Replace(" ", "");
            string minusculo = removerEspaco.ToLower();

            Console.WriteLine($"A palavra é: {minusculo}");

        }
    }
}