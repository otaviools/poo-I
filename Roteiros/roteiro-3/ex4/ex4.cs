class Retangulo
{
  public int Largura { get; set; }
  public int Altura { get; set; }

  public int Area
  {
    get
    {
      return Largura * Altura;
    }
  }
}

class Program
{
  static void Main()
  {
    Retangulo retangulo = new Retangulo();

    retangulo.Largura = 20;
    retangulo.Altura = 10;

    Console.WriteLine($"Largura: {retangulo.Largura}");
    Console.WriteLine($"Altura: {retangulo.Altura}");
    Console.WriteLine($"Area: {retangulo.Area}");
  }
}