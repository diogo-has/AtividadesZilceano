using System;
using System.Collections.Generic;
using Empresa2;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Cliente joao = new Cliente("João", "joao@example.com");
            Produto suco = new Produto("Suco de uva", 12.9f);
            Produto macarrao = new Produto("Macarrão espaguete", 6.7f);

            List<Produto> produtos = new List<Produto>();

            produtos.Add(suco);
            produtos.Add(macarrao);

            Carrinho carrinho1 = new Carrinho(joao, produtos);

            foreach (Produto a in carrinho1.Produtos)
            {
                Console.WriteLine($"Nome: {a.Nome}\nPreço: {a.Preco}");
            }
        }
    }
}