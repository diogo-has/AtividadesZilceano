namespace projetinho.Models;

public class Produto {
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public decimal Valor { get; set; }
    public Fornecedora Fornecedora { get; set; }
}