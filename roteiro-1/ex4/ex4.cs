public class ContaBancaria
{
  public string titular;
  public int numeroConta;
  public float saldo;

  public void Depositar(float valor)
  {
    Console.WriteLine($"Valor R${valor} depositado");
    saldo+=valor;
  }

  public void Sacar(float valor)
  {
    if(saldo < valor)
    {
      Console.WriteLine("Nao e possivel sacar !");
    }
    else
    {
      saldo -= valor;
      Console.WriteLine($"R${valor} sacado com sucesso !");
    }
  }

  public float ExibirSaldo()
  {
    return saldo;
  }
}

public class program
{
  public static void Main()
  {
    ContaBancaria p1 = new ContaBancaria();
    p1.Depositar(1500);
    p1.Sacar(280);
    Console.WriteLine($"Total na conta R${ p1.ExibirSaldo()}");

    ContaBancaria p2 = new ContaBancaria();
    p2.Depositar(3000);
    p2.Sacar(500);
    Console.WriteLine($"Total na conta R${ p2.ExibirSaldo()}");
  }
}
