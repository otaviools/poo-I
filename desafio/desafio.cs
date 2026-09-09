 class Carro
  {
    public string? Placa { get; set; }
    public string? Modelo { get; set; }
    public string? Entrada { get; set; }
    public string? Saida { get; set; }

    private decimal ValorPago { get; set; }

    

    public void PlacaCarro(string placa)
    {
      if(placa.Length > 0 && placa.Length <= 7)
      {
        this.Placa = placa;
      }
      else
      {
        Console.WriteLine("Placa inválida, digite novamente");
      }
    }
    public void ModeloCarro(string modelo)
    {
      if(modelo.Length >= 0)
      {
        this.Modelo = modelo;
      }
      else
      {
        Console.WriteLine("Modelo inválido, digite novamente");
      }
    }
    public void EntradaCarro(string entrada)
    {
      this.Entrada = entrada;
    }
    public void SaidaCarro(string saida)
    {
      this.Saida = saida;
    }
    public void CalcularPagamentoCarro()
    {
      if(Entrada != null && Saida != null)
      {
        Entrada = Entrada.Replace(":", "");
        Saida = Saida.Replace(":", "");
        int tempoEstacionado = int.Parse(Saida) - int.Parse(Entrada);
        ValorPago = int.Parse(tempoEstacionado.ToString()) * 10;
      }
      else
      {
        Console.WriteLine("Não é possível calcular o valor pago sem a entrada e saída do carro.");
      }
    }
    public void mostrarDados()
    {
      Console.WriteLine($"Placa: {Placa}");
      Console.WriteLine($"Modelo: {Modelo}");
      Console.WriteLine($"Entrada: {Entrada}");
      Console.WriteLine($"Saida: {Saida}");
      Console.WriteLine($"Valor pago: {ValorPago}");
    }
}

class program
{
  public static void Main()
  {
    Carro carro = new Carro();
    carro.PlacaCarro("ABC1234");
    carro.ModeloCarro("Fusca");
    carro.EntradaCarro("10:30");
    carro.SaidaCarro("12:30");
    carro.CalcularPagamentoCarro();
    carro.mostrarDados();
  }
}

 