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
        static int ContarConsoantes(string texto)
        {
            string vogais = "aeiou";
            int contador = 0;

            foreach(char c in texto)
            {
                if (char.IsLetter(c) && !vogais.Contains(c))
                {
                    contador++;
                }
            }

            return contador;
        }

        static void Main()
        {
            Console.Write("Digite a palavra: ");
            string? palavra = Console.ReadLine();

            if (string.IsNullOrEmpty(palavra))
            {
                Console.WriteLine("Palavra inválida!");
                return;
            }

            string resultado = palavra.Replace(" ", "").ToLower();

            int total = ContarConsoantes(resultado);

            Console.WriteLine($"Palavra: {resultado}");
            Console.WriteLine($"Consoantes: {total}");            
        }
    }
}