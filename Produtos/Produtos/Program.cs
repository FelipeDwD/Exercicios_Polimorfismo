using Produtos.Entidades;
using System;
using System.Collections.Generic;

namespace Produtos
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("pt-BR");

            List<Produto> produtos = new List<Produto>();

            Console.Write("Digite o número de produtos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Digite os dados do {(i + 1)}º produto: ");
                Console.Write("C - Comum | I - Importado | U - Usado: ");
                char opcao = char.Parse(Console.ReadLine());

                Console.Write("Digite o nome do produto: ");
                string nome = Console.ReadLine();

                Console.Write($"Qual preço do(a) {nome}: ");
                double preco = double.Parse(Console.ReadLine());

                if (opcao == 'C' || opcao == 'c')
                {
                    produtos.Add(new Produto(nome, preco));
                }else if (opcao == 'I' || opcao == 'i')
                {
                    Console.Write("Qual valor da alfândega? ");
                    double valorAlfandega = double.Parse(Console.ReadLine());

                    produtos.Add(new ProdutoImportado(nome, preco, valorAlfandega));
                }else if (opcao == 'U' || opcao == 'u')
                {
                    Console.Write("Digite a data de fabricação: ");
                    DateTime dataFabricao = DateTime.Parse(Console.ReadLine(), culture);

                    produtos.Add(new ProdutoUsado(nome, preco, dataFabricao));
                }
                    
            }

            foreach (Produto produto in produtos)
            {
                Console.WriteLine(produto.Etiqueta());
            }

        }
    }
}
