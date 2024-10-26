//Inicialização da classe Reserva
public class Reserva
{
    public string Codigo { get; set; }
    public Cliente Cliente { get; set; }
    public PacoteTuristico Pacote { get; set; }
    public DateTime DataReserva { get; set; }
  //construtores
    public Reserva(Cliente cliente, PacoteTuristico pacote)
    {
        Codigo = Guid.NewGuid().ToString();  // Gera um código único para a reserva
        Cliente = cliente;
        Pacote = pacote;
        DataReserva = DateTime.Now;
    }
    // Utilizada pelo cancelamento na agencia
    public void Cancelar()
    {
        Console.WriteLine($"Reserva {Codigo} cancelada.");
    }

    public string Detalhes()
    {
        return $"{Cliente.Nome} reservou {Pacote.Nome}";
    }
}
