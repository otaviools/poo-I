//1. Crie uma classe base chamada Pagamento .
//2. Crie nela um método virtual ProcessarPagamento() .
//3. Crie as classes CartaoCredito , BoletoBancario e Pix .
//4. Faça as três classes herdarem de Pagamento .
//5. Sobrescreva ProcessarPagamento() em cada classe.
//6. Exiba uma mensagem diferente para cada forma de pagamento.
//7. No Main() , crie uma List<Pagamento> .
//8. Adicione diferentes tipos de pagamento à lista.
//9. Percorra a lista e chame ProcessarPagamento()

class Pagamento
{
  public virtual void ProcessarPagamento()
  {
  }
}

class CartaoCredito : Pagamento
{
  public override void ProcessarPagamento()
  {
    base.ProcessarPagamento();
    Console.WriteLine("processando pagamento credito");
  }
}

class BoletoBancario : Pagamento
{
  public override void ProcessarPagamento()
  {
    base.ProcessarPagamento();
    Console.WriteLine("processando pagamento boleto");
  }
}

class Pix : Pagamento
{
  public override void ProcessarPagamento()
  {
    base.ProcessarPagamento();
    Console.WriteLine("processando pagamento pix");
  }
}

class Program
{
  static void Main()
  {
    List<Pagamento> pagamentos = new List<Pagamento>();
    pagamentos.Add(new Pix());
    pagamentos.Add(new CartaoCredito());
    pagamentos.Add(new BoletoBancario());
    foreach (Pagamento pagamento in pagamentos)
    {
      pagamento.ProcessarPagamento();
    }
  }
}