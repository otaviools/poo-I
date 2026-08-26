Console.WriteLine("Digite um numero: ");
string num = Console.ReadLine();

int resultado;
bool validar = int.TryParse(num, out resultado);

if(validar == true)
{
  Console.WriteLine($"Seu número é: {num}");
}
else
{
  Console.WriteLine("Entrada Inválida. Digite um número válido");
  Console.ReadLine();
}