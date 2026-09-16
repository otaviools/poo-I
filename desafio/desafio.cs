class Carro
{
  public string placa {get; set;}
  public string modelo {get; set;}
  public string horarioEntrada {get; set;}
  public string horarioSaida {get; set;}

  public decimal valor = 0;
  public decimal valorPago
  {
    get{ return valor;}
    private set
    {
      valor = value;
    }
  }

}