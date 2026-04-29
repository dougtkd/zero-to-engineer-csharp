/*1. ler palavra
2. validar
3. remover espaços
4. deixar minúsculo
5. criar lista de vogais
6. contador = 0
7. percorrer cada letra
8. se for letra e não for vogal → contador++
9. imprimir resultado*/

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
                Console.WriteLine("Palavra inválida!");
                return;
            }

            string removerEspacos = palavra.Replace(" ", "");
            string deixarMinusculo = removerEspacos.ToLower();

            string vogais = "aeiou";
            int contador = 0;

            foreach(char c in deixarMinusculo)
            {
                if (char.IsLetter(c) && !vogais.Contains(c))
                {
                    contador++;
                }
            }

            Console.WriteLine($"Palavra: {deixarMinusculo}");
            Console.WriteLine($"Número de consoantes: {contador}");
        }
    }
}