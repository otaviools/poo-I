class Produto
{
  private string nome;
  private decimal preco;

  public Produto(string nome, decimal preco)
  {
   this.nome = nome;
   this.preco = preco;
  }

   public void AlterarPreco(decimal novoPreco)
  {
    if(novoPreco > 0)
    {
      preco = novoPreco;
      Console.WriteLine($"Preco: {preco}");
    }
    else
    {
      Console.WriteLine("Preco negativo !");
    };
  }
  public void ExibirDetalhes()
  {
    Console.WriteLine($"Nome: {nome}, Preco: {preco}");
  }
}

public class program
{
  public static void Main()
  {
    Produto p = new Produto("Celular", 1500);
    p.ExibirDetalhes();
    p.AlterarPreco(-200);
    p.AlterarPreco(1200);
    p.ExibirDetalhes();
  }
}