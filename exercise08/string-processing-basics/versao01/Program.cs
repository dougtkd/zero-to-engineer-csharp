/*📌 Problema:

Peça uma palavra ao usuário e:

Remova todos os espaços
Converta tudo para minúsculo
Conte quantas consoantes existem
Exiba o resultado */

using System;
using System.Collections.Generic;

namespace StringConsonant
{
    public class Program
    {
        static void Main()
        {
            Console.Write("Digite uma frase ou palavra: ");
            string input = Console.ReadLine()!;

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Entrada inválida!");
                return;
            }

            string processada = input.Replace(" ", "").ToLower();

            int contadorConsoantes = 0;
            string vogais = "aeiou";

            foreach (char c in processada)
            {
                if (char.IsLetter(c))
                {
                    if (!vogais.Contains(c))
                    {
                        contadorConsoantes++;
                    }
                }
            }

            Console.WriteLine($"\nString tratada: {processada}");
            Console.WriteLine($"Quantidade de consoantes: {contadorConsoantes}");
        }
    }
}