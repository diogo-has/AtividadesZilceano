using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using projetinho.Models;

namespace projetinho.Controllers;

public class PedidosController : Controller
{
    public IActionResult Index() {

        List<Cliente> clientes = new List<Cliente> {
            new Cliente {
                Id = 1,
                Nome = "João",
                CPF = "123.456.789-89",
                Email = "joao@example.com",
                Telefone = "11 99999-9909"
            },
            new Cliente {
                Id = 2,
                Nome = "Pedro",
                CPF = "987.654.321-89",
                Email = "pedro@example.com",
                Telefone = "12 94967-9509"
            },
            new Cliente {
                Id = 3,
                Nome = "Maria",
                CPF = "739.465.226-55",
                Email = "maria@example.com",
                Telefone = "14 97845-4545"
            }
        };

        List<Fornecedora> fornecedoras = new List<Fornecedora> {
            new Fornecedora {
                Id = 1,
                Nome = "CeluMax",
                Endereco = "Rua Bonita, 223",
                MargemDesconto = 10m,
                RegimeFiscal = "LTDA",
                Cnpj = "50.228.172/0001-95"
            },
            new Fornecedora {
                Id = 2,
                Nome = "CadeiraCorp",
                Endereco = "Rua Bela, 423",
                MargemDesconto = 15m,
                RegimeFiscal = "SA",
                Cnpj = "64.786.277/0001-74"
            },
            new Fornecedora {
                Id = 3,
                Nome = "AzeiteUltra",
                Endereco = "Rua das Flores, 10",
                MargemDesconto = 5m,
                RegimeFiscal = "LTDA",
                Cnpj = "84.773.581/0001-94"
            }
        };

        List<Produto> produtos = new List<Produto> {
            new Produto {
                Id = 1,
                Nome = "MegaPhone",
                Valor = 1099.99m,
                Fornecedora = fornecedoras.Find(Fornecedora => Fornecedora.Id == 1)
            },
            new Produto {
                Id = 2,
                Nome = "AlphaPhone",
                Valor = 1999.99m,
                Fornecedora = fornecedoras.Find(Fornecedora => Fornecedora.Id == 1)
            },
            new Produto {
                Id = 3,
                Nome = "Mega Cadeira",
                Valor = 199.90m,
                Fornecedora = fornecedoras.Find(Fornecedora => Fornecedora.Id == 2)
            },
            new Produto {
                Id = 4,
                Nome = "Cadeira da boa",
                Valor = 50.99m,
                Fornecedora = fornecedoras.Find(Fornecedora => Fornecedora.Id == 2)
            },
            new Produto {
                Id = 5,
                Nome = "Azeite de Oliva",
                Valor = 30.99m,
                Fornecedora = fornecedoras.Find(Fornecedora => Fornecedora.Id == 3)
            },
            new Produto {
                Id = 6,
                Nome = "Azeite de Trufa",
                Valor = 60.70m,
                Fornecedora = fornecedoras.Find(Fornecedora => Fornecedora.Id == 3)
            },
        };

        List<Pedido> pedidos = new List<Pedido> {
            new Pedido {
                Id = 1,
                Status = "Enviado",
                DataEntrada = DateTime.Now,
                FuncResponsavel = "Cleber Rocha",
                Cliente = clientes.Find(Cliente => Cliente.Id == 1),
                Produtos = new List<Produto> {
                    produtos.Find(Produto => Produto.Id == 1),
                    produtos.Find(Produto => Produto.Id == 6),
                    produtos.Find(Produto => Produto.Id == 4),
                }
            },
            new Pedido {
                Id = 2,
                Status = "Entregue",
                DataEntrada = DateTime.Now,
                FuncResponsavel = "Alberto Almeida",
                Cliente = clientes.Find(Cliente => Cliente.Id == 2),
                Produtos = new List<Produto> {
                    produtos.Find(Produto => Produto.Id == 2),
                    produtos.Find(Produto => Produto.Id == 3),
                    produtos.Find(Produto => Produto.Id == 1),
                }
            },
            new Pedido {
                Id = 3,
                Status = "Preparando",
                DataEntrada = DateTime.Now,
                FuncResponsavel = "Diana Machado",
                Cliente = clientes.Find(Cliente => Cliente.Id == 3),
                Produtos = new List<Produto> {
                    produtos.Find(Produto => Produto.Id == 5),
                    produtos.Find(Produto => Produto.Id == 2),
                    produtos.Find(Produto => Produto.Id == 6),
                }
            }
        };

        return View(pedidos);
    }
}
