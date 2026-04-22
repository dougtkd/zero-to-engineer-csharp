// Gerenciador de estoque simples
/*Seu Novo Exercício (Semelhante, mas com um toque novo):
Título: Gerenciador de Estoque Simples
Crie uma classe Produto com Nome (string) e Preco (double).
Peça ao usuário para cadastrar 3 produtos.
Ao final, o programa deve mostrar:
O valor total do estoque (soma dos preços).
O nome do produto mais caro.
Uma lista apenas dos produtos que custam menos de R$ 50,00 (promoção).
Regra: Tente escrever esse código do zero, sem copiar do de cima, apenas usando-o como consulta para a sintaxe.
Consegue ver as semelhanças entre o Aluno/Nota e o Produto/Preço? É a mesma lógica, apenas com nomes diferentes! Boa sorte, Engineer! */

using System;
using System.Collections.Generic;
using System.Linq;

namespace GerenciadorEstoque
{
    public class Product
    {
        public string Nome { get; set; } = string.Empty;
        public double Preço { get; set; }
    }

    class Program
    {
        static void Main()
        {
            List<Product> listaProdutos = new List<Product>();
            double somaPreços = 0;

            for (int i = 0; i < 3; i++)
            {
                Product produtoNovo = new Product();

                Console.Write($"Digite o nome do {i + 1}º produto: ");
                produtoNovo.Nome = Console.ReadLine() ?? "";

                Console.Write($"Digite o valor do {produtoNovo.Nome}: ");
                string entradaValor = Console.ReadLine() ?? "0";
                produtoNovo.Preço = double.Parse(entradaValor);

                somaPreços += produtoNovo.Preço;
                listaProdutos.Add(produtoNovo);

                Console.WriteLine("---");
            }

            double mediaEstoque = somaPreços / listaProdutos.Count;

            Product produtoDestaque = listaProdutos[0];
            foreach (var produto in listaProdutos)
            {
                if (produto.Preço > produtoDestaque.Preço)
                {
                    produtoDestaque = produto;
                }
            }

            Console.Clear();
            Console.WriteLine("===== RELATÓRIO FINAL =====");
            Console.WriteLine($"Média geral de produtos: {mediaEstoque:F2}");
            Console.WriteLine($"Produto mais caro: {produtoDestaque.Nome} (Preço: {produtoDestaque.Preço})");

            Console.WriteLine("\nLista de produtos em promoção:");
            foreach (var produto in listaProdutos)
            {
                if (produto.Preço <= 50)
                {
                    Console.WriteLine($"- {produto.Nome} (Preço: {produto.Preço})");
                }
            }
        }
    }
}