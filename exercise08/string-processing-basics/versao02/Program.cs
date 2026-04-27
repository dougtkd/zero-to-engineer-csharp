using System;
using System.Collections.Generic;

namespace EstudoCsharp
{
    public class Program
    {
        static void Main()
        {
           Console.Write("Digite alguma palavra: ");
           string? palavra = Console.ReadLine();

           if (string.IsNullOrEmpty(palavra))
            {
                Console.WriteLine("Entrada inválida!");
                return;
            }

           Console.WriteLine($"Segue a sua palavra: {palavra}");

           string semEspacos = palavra.Replace(" ", "");
           Console.WriteLine(semEspacos);
        }
    }
}