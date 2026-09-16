public class Veiculo
{
  public string marca;
  public string modelo;
  public int NumeroDeRodas;

  public void ExibirDados()
  {
    Console.WriteLine($"Marca: {marca}");
    Console.WriteLine($"Modelo: {modelo}");
    Console.WriteLine($"Número de Rodas: {NumeroDeRodas}");
  }
}

public class Carro : Veiculo
{
  public int NumeroDePortas;

}

public class Moto : Veiculo
{
  public bool PossuiBagageiro;

}

class program
{
  static void Main()
  {
    Carro carro = new Carro();
    carro.marca = "Toyota";
    carro.modelo = "Corolla";
    carro.NumeroDeRodas = 4;
    carro.NumeroDePortas = 4;

    Moto moto = new Moto();
    moto.marca = "Honda";
    moto.modelo = "CB500";
    moto.NumeroDeRodas = 2;
    moto.PossuiBagageiro = true;

    Console.WriteLine("Dados do Carro:");
    carro.ExibirDados();
    Console.WriteLine($"Número de Portas: {carro.NumeroDePortas}");
    Console.WriteLine();

    Console.WriteLine("Dados da Moto:");
    moto.ExibirDados();
    Console.WriteLine($"Possui Bagageiro: {moto.PossuiBagageiro}");
  }
}