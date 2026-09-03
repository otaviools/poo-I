class Pessoa
{
  public string Nome { get; private set; }
  public int Idade { get; set; }
  public string Email { get; set; }
}

class Program
{
  static void Main()
  {
    Pessoa pessoa = new Pessoa();
    pessoa.Nome = "João";
    pessoa.Idade = 45;
    pessoa.Email = "joao@gmail.com";
    Console.WriteLine($"Nome: {pessoa.Nome}, Idade: {pessoa.Idade}, Email: {pessoa.Email}");
  }
}