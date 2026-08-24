class Carro
{
  private string modelo;
  private int velocidadeatual;

  public Carro(string modelo)
  {
    this.modelo = modelo;
  }

  public void Acelerar(int valor)
  {
    if(valor >= 0)
    {
      velocidadeatual += valor;
    }
    else
    {
      Console.WriteLine("Velocidade negativa !");
    }
  }
  public void Frear(int valor)
  {
   velocidadeatual -= valor;
   if(valor > velocidadeatual)
    {
      velocidadeatual = 0;
    }
  }
  public void ExibirVelocidade()
  {
    {
      Console.WriteLine($"Velocidade atual: {velocidadeatual}");
    }
  }
}

public class program
{
  public static void Main()
  {
    Carro c = new Carro("Ferrari");
    c.Acelerar(50);
    c.Frear(60);
    c.ExibirVelocidade();
  }
}