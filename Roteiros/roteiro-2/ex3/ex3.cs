public class Elevador
{
  private int andarAtual = 0;
  private int totalAndares;

  public Elevador(int totalAndares)
  {
    this.totalAndares = totalAndares;
  }

  public void Subir()
  {
    if(andarAtual < totalAndares)
    {
      andarAtual += 1;
    }
    else
    {
      Console.WriteLine("Esse ap não possui asas. :) ");
    }
  }
  public void Descer()
  {
    if(andarAtual <= totalAndares && andarAtual > 0)
    {
      andarAtual -= 1;
    }
    else
    {
      Console.WriteLine("Esse ap não possui subsolo. :) ");
    }
  }

  public void ExibirAndar()
  {
    Console.WriteLine(andarAtual);
  }
}

public class program
{
  public static void Main()
  {
    Elevador e = new Elevador(3);

   e.Descer();
   e.ExibirAndar();

   e.Subir();
   e.Subir();
   e.Subir();
   e.Subir();

   e.ExibirAndar();

  }
}