namespace projetinho.Models;

public class Pedido {
    public int Id { get; set; }
    public string Status { get; set; } = "";
    public DateTime DataEntrada { get; set; }
    public string FuncResponsavel { get; set;} = "";
    public Cliente Cliente { get; set;}
    public List<Produto> Produtos { get; set;}
}