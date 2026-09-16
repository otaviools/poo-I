public class Pessoa
{
  public string nome;
}

public class Casa
{
  public Pessoa pessoa;

  public Casa()
  {
    pessoa = new Pessoa();
  }
  public void ExibirMorador()
  {
    Console.WriteLine($"Morador: {pessoa.nome}");
  }
}

class program
{
  static void Main()
  {
    Pessoa pessoa = new Pessoa();
    pessoa.nome = "João";

    Casa casa = new Casa();
    casa.pessoa = pessoa;
    casa.ExibirMorador();
  }
}