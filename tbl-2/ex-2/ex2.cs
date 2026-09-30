//1. Crie uma classe abstrata chamada Funcionario .
//2. Crie um método abstrato CalcularSalario() .
//3. Crie as classes Gerente e Programador .
//4. Faça ambas herdarem de Funcionario .
//5. Implemente CalcularSalario() com um cálculo diferente em cada classe.
//6. No Main() , crie um gerente e um programador.
//7. Chame CalcularSalario() para cada objeto.
//8. Exiba os salários.

//Desafio adicional
//Crie uma List<Funcionario> , adicione um gerente e um programador e percorra a lista utilizando foreach.


abstract class Funcionario
{
  public abstract double CalcularSalario();
}

class Gerente : Funcionario
{
  public override double CalcularSalario()
  {
    return 10000;
  }
}

class Programador : Funcionario
{
  public override double CalcularSalario()
  {
    return 2000;
  }
}

class Program
{
  static void Main()
  {
    /*Programador p1 = new Programador();
    Gerente g1 = new Gerente();

    p1.CalcularSalario();
    g1.CalcularSalario();

    Console.WriteLine($"o gerente ganha:R${g1.CalcularSalario()}");
    Console.WriteLine($"o funcionario ganha: R${p1.CalcularSalario()}");*/
    List<Funcionario> funcionarios = new List<Funcionario>();
    funcionarios.Add(new Gerente());
    funcionarios.Add(new Programador());
    foreach (Funcionario funcionario in funcionarios)
    {
      funcionario.CalcularSalario();
      Console.WriteLine("pagamento processado");
    }
  }
}

