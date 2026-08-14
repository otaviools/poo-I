public class Fantasminhas
{
  public string habilidade;
  public string nick;
  public string cor; 

  public void gerarFantasma()
  {
    Console.WriteLine($"Fanstaminha iniciado sua habilidade é {habilidade} seu nick é {nick} e sua cor é {cor}");
  }

  public void Mover(string direcao)
  {
      Console.WriteLine($"{nick} se moveu para {direcao}");
  }
}

public class program
{
  public static void Main()
  {
    Fantasminhas otavio = new Fantasminhas();
    otavio.nick = "flamengo";
    otavio.cor = "rubronegro";
    otavio.habilidade = "amassador";
    otavio.gerarFantasma();
    otavio.Mover("libertadores");
  }
}