class Pessoa
{
  public string nome;

}

public class program
{
  public static void Main()
  {
    Pessoa p1 = new Pessoa();

    p1.nome = "Otavio";

    Pessoa p2 = p1;

    p2.nome = "Flamengo";
    Console.WriteLine(p1.nome);
    Console.WriteLine(p2.nome);
  }
}