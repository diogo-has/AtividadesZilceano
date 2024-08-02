namespace projetinho.Models;

public class Fornecedora {
    public int Id { get; set; }
    public string Nome { get; set; } = "";
    public string Endereco { get; set; } = "";
    public decimal MargemDesconto { get; set; }
    public string RegimeFiscal { get; set; }
    public string Cnpj { get; set; }
}