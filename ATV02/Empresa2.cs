using System;
using System.Collections.Generic;

namespace Empresa2
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Email { get; set; }

        public Cliente(string nome, string email)
        {
            Nome = nome;
            Email = email;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}\nEmail: {Email}");
        }
    }

    public class Produto
    {
        public string Nome { get; set; }
        public float Preco { get; set; }

        public Produto(string nome, float preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public void ExibirInfo()
        {
            Console.WriteLine($"Nome: {Nome}\nPreço: {Preco}");
        }
    }

    public class Carrinho
    {
        public Cliente Cliente { get; set; }
        public List<Produto> Produtos { get; set; }

        public Carrinho(Cliente cliente, List<Produto> produtos)
        {
            Cliente = cliente;
            Produtos = produtos;
        }
    }
}
