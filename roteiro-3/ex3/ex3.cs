class Produto
{
  private decimal preco;
  private string nome;

  public decimal Preco
  {
    get
    {
      return preco;
    }
    set
    {
      if (value < 0)
      {
        throw new ArgumentException("O preco nao pode ser negativo.");
      }
      preco = value;
    }
  }

  public string Nome
  {
    get
    {
      return nome;
    }
    set
    {
      if (string.IsNullOrWhiteSpace(value))
      {
        throw new ArgumentException("O nome nao pode ser vazio.");
      }
      nome = value;
    }
  }
}

class Program
{
  public static void Main()
  {
    Produto produto = new Produto();

    try
    {
      produto.Preco = 100;
      Console.WriteLine($"Preco alterado para {produto.Preco:C}");

      produto.Preco = 250;
      Console.WriteLine($"Preco alterado para {produto.Preco:C}");

      produto.Preco = -50;
      Console.WriteLine($"Preco alterado para {produto.Preco:C}");
    }
    catch (ArgumentException erro)
    {
      Console.WriteLine($"Erro: {erro.Message}");
    }

    Console.WriteLine($"Preco atual: {produto.Preco:C}");

    try
    {
      produto.Nome = "Teclado";
      Console.WriteLine($"Nome alterado para {produto.Nome}");

      produto.Nome = "";
      Console.WriteLine($"Nome alterado para {produto.Nome}");
    }
    catch (ArgumentException erro)
    {
      Console.WriteLine($"Erro: {erro.Message}");
    }

    Console.WriteLine($"Nome atual: {produto.Nome}");
  }
}
