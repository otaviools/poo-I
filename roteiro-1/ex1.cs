public class Pessoa
{
  public string Nome;
  public int Idade;
  public string Cargo;
  public void apresentar()
  {
    Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos. Meu cargo é {Cargo}");
  }
  public void mostrarsalario()

  {
    int salario = 0;

    if (Cargo == "Gerente")
    {
      salario = 10000;
    }
    if (Cargo == "Desenvolvedor")
    {
      salario = 5000;
    }
    if (Cargo == "Estagiario")
    {
      salario = 100;
    }
    Console.WriteLine($"Meu salario é {salario}");
  }
}

public class program
{
  public static void Main()
  {
    Pessoa p1 = new Pessoa();
    p1.Idade = 19;
    p1.Nome = "Otavio";
    p1.Cargo = "Gerente";
    p1.apresentar();
    p1.mostrarsalario();

    Pessoa p2 = new Pessoa();
    p2.Idade = 20;
    p2.Nome = "Pedro";
    p2.Cargo = "Desenvolvedor";
    p2.apresentar();
    p2.mostrarsalario();

    Pessoa p3 = new Pessoa();
    p3.Idade = 24;
    p3.Nome = "Paulo";
    p3.Cargo = "Estagiario";
    p3.apresentar(); 
    p3.mostrarsalario();
  }
}