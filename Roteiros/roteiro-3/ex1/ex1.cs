public class ContaBancaria
{
  public decimal Saldo
  {
    get { return Saldo; }
    private set;
  }
  public void Depositar(decimal valor)
  {
    if(valor > 0)
    {
      Saldo += valor;
    }
  }
}

class program
{
  static void Main()
  {
    ContaBancaria conta = new ContaBancaria();
    conta.Depositar(1000);
    Console.WriteLine($"Saldo atual: R${conta.Saldo}");
    //conta.Saldo = 500; // Erro: não é possível acessar o campo saldo diretamente, pois ele é privado
  }
}