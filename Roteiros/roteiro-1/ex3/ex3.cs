public class Produto
{
  public string nome;
  public float preco;
  public int quantidade;

  public void ExibirDados()
  {
    Console.WriteLine($"O produto {nome} com preco de R${preco} e {quantidade} quantidade(s)");
  }
  public float CalcularValorTotal()
  {
    return preco * quantidade;
    
  }
}

public class program
{
  public static void Main()
  {
    Produto p1 = new Produto();
    p1.nome = "Banana";
    p1.preco = 5;
    p1.quantidade = 8;
    p1.ExibirDados();
    Console.WriteLine($"O total do produto é R$:{p1.CalcularValorTotal()}");

    Produto p2 = new Produto();
    p2.nome = "Maçã";
    p2.preco = 2;
    p2.quantidade = 50;
    p2.ExibirDados();
     Console.WriteLine($"O total do produto é R$:{p2.CalcularValorTotal()}");

    Produto p3 = new Produto();
    p3.nome = "Pera";
    p3.preco = 7;
    p3.quantidade = 15;
    p3.ExibirDados();
     Console.WriteLine($"O total do produto é R$:{p3.CalcularValorTotal()}");
  }
}