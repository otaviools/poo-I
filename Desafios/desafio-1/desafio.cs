class Veiculo
{
    private const decimal ValorPorHora = 10;

    public string Placa { get; private set; }
    public string Modelo { get; private set; }
    public DateTime HorarioEntrada { get; private set; }
    public DateTime HorarioSaida { get; private set; }
    public decimal ValorPago { get; private set; }
    public bool EstaEstacionado { get; private set; }

    public Veiculo(string placa, string modelo)
    {
        if (string.IsNullOrWhiteSpace(placa))
        {
            throw new Exception("A placa não pode ser vazia.");
        }

        Placa = placa.ToUpper();
        Modelo = modelo;
    }

    public void RegistrarEntrada(DateTime horario)
    {
        if (EstaEstacionado)
        {
            throw new Exception("O veículo " + Placa + " já está estacionado.");
        }

        HorarioEntrada = horario;
        EstaEstacionado = true;
        ValorPago = 0;
    }

    public void RegistrarSaida(DateTime horario)
    {
        if (!EstaEstacionado)
        {
            throw new Exception("O veículo " + Placa + " não está estacionado.");
        }

        if (horario < HorarioEntrada)
        {
            throw new Exception("A hora de saída não pode ser anterior à hora de entrada.");
        }

        HorarioSaida = horario;
        EstaEstacionado = false;
        ValorPago = CalcularValor();
    }

    public TimeSpan CalcularTempoPermanencia()
    {
        return HorarioSaida - HorarioEntrada;
    }

    private decimal CalcularValor()
    {
        double horas = Math.Ceiling(CalcularTempoPermanencia().TotalHours);

        if (horas < 1)
        {
            horas = 1;
        }

        return (decimal)horas * ValorPorHora;
    }

    public void Exibir()
    {
        Console.WriteLine();
        Console.WriteLine("Placa: " + Placa);
        Console.WriteLine("Modelo: " + Modelo);
        Console.WriteLine("Entrada: " + HorarioEntrada.ToString("HH:mm"));

        if (EstaEstacionado)
        {
            Console.WriteLine("Situação: estacionado");
            return;
        }

        TimeSpan tempo = CalcularTempoPermanencia();

        Console.WriteLine("Saída: " + HorarioSaida.ToString("HH:mm"));
        Console.WriteLine("Permanência: " + tempo.Hours + "h" + tempo.Minutes + "min");
        Console.WriteLine("Valor pago: R$ " + ValorPago.ToString("F2"));
    }
}

class Estacionamento
{
    private const int Capacidade = 5;

    private List<Veiculo> veiculos = new List<Veiculo>();

    public int VagasDisponiveis()
    {
        return Capacidade - veiculos.Count;
    }

    public Veiculo? BuscarVeiculo(string placa)
    {
        foreach (Veiculo veiculo in veiculos)
        {
            if (veiculo.Placa == placa.ToUpper())
            {
                return veiculo;
            }
        }

        return null;
    }

    public void RegistrarEntrada(Veiculo veiculo, DateTime horario)
    {
        if (BuscarVeiculo(veiculo.Placa) != null)
        {
            throw new Exception("O veículo " + veiculo.Placa + " já está estacionado.");
        }

        if (VagasDisponiveis() == 0)
        {
            throw new Exception("Não há vagas disponíveis.");
        }

        veiculo.RegistrarEntrada(horario);
        veiculos.Add(veiculo);
    }

    public void RegistrarSaida(string placa, DateTime horario)
    {
        Veiculo? veiculo = BuscarVeiculo(placa);

        if (veiculo == null)
        {
            throw new Exception("O veículo " + placa + " não está no estacionamento.");
        }

        veiculo.RegistrarSaida(horario);
        veiculos.Remove(veiculo);
    }

    public void ListarVeiculos()
    {
        Console.WriteLine();
        Console.WriteLine("Veículos estacionados: " + veiculos.Count + " de " + Capacidade);

        foreach (Veiculo veiculo in veiculos)
        {
            veiculo.Exibir();
        }
    }
}

class Program
{
    static void Main()
    {
        DateTime hoje = DateTime.Today;
        Estacionamento estacionamento = new Estacionamento();

        Veiculo audi = new Veiculo("ABC1D23", "Audi A3");
        estacionamento.RegistrarEntrada(audi, hoje.AddHours(10));
        audi.Exibir();

        estacionamento.RegistrarSaida("ABC1D23", hoje.AddHours(10).AddMinutes(30));
        audi.Exibir();

        try
        {
            Veiculo semPlaca = new Veiculo("", "Gol");
        }
        catch (Exception erro)
        {
            MostrarErro(erro);
        }

        Veiculo civic = new Veiculo("XYZ9K87", "Civic");
        estacionamento.RegistrarEntrada(civic, hoje.AddHours(8));

        try
        {
            estacionamento.RegistrarEntrada(civic, hoje.AddHours(9));
        }
        catch (Exception erro)
        {
            MostrarErro(erro);
        }

        try
        {
            estacionamento.RegistrarSaida("XYZ9K87", hoje.AddHours(7));
        }
        catch (Exception erro)
        {
            MostrarErro(erro);
        }

        estacionamento.RegistrarEntrada(new Veiculo("DEF4G56", "Onix"), hoje.AddHours(8));
        estacionamento.RegistrarEntrada(new Veiculo("GHI7J89", "HB20"), hoje.AddHours(9));
        estacionamento.RegistrarEntrada(new Veiculo("JKL1M23", "Corolla"), hoje.AddHours(9));
        estacionamento.RegistrarEntrada(new Veiculo("MNO4P56", "Kwid"), hoje.AddHours(10));

        try
        {
            estacionamento.RegistrarEntrada(new Veiculo("QRS7T89", "Uno"), hoje.AddHours(11));
        }
        catch (Exception erro)
        {
            MostrarErro(erro);
        }

        Console.WriteLine();
        Console.WriteLine("Vagas disponíveis: " + estacionamento.VagasDisponiveis());

        estacionamento.RegistrarSaida("XYZ9K87", hoje.AddHours(10).AddMinutes(15));
        civic.Exibir();

        Console.WriteLine();
        Console.WriteLine("Vagas disponíveis: " + estacionamento.VagasDisponiveis());

        estacionamento.ListarVeiculos();
    }

    static void MostrarErro(Exception erro)
    {
        Console.WriteLine();
        Console.WriteLine("Operação recusada: " + erro.Message);
    }
}
