class ContaBancaria
{
  public string Titular { get; set; }

  public ContaBancaria(string titular)
  {
    Titular = titular;
  }
  public decimal saldo = 0;

  public decimal Saldo
  {
    get { return saldo; }
    private set
    {
      saldo = value;
    }
  }

  public void Depositar(decimal valor)
  {
    if (valor > 0)
    {
      Saldo += valor;
    }
  }

  public void Sacar(decimal valor)
  {
    if (valor > 0 && valor <= Saldo)
    {
      Saldo -= valor;
    }
    else
    {
      throw new ArgumentException("O preco nao pode ser negativo.");
    }
  }
}

class program
{
  static void Main()
  {
    ContaBancaria conta = new ContaBancaria("João");
    conta.Depositar(1000);
    try
    {
      conta.Sacar(250);
      Console.WriteLine($"Saldo após saque: {conta.Saldo}");
    }
    catch (ArgumentException ex)
    {
      Console.WriteLine($"Erro: {ex.Message}");
    }
  }
}

