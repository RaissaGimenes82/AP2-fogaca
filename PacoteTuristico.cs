//Incialização da classe PacoteTuristico que herdou de outras
public class PacoteTuristico : ServicoViagem, IPesquisavel, IReservavel
{
    public Destino Destino { get; set; }
    public DateTime DateTimeInicio { get; set; }
    public DateTime DateTimeFim { get; set; }
    public decimal Preco { get; set; }
    public string Nome { get; set; }
    private int vagasDisponiveis;
     
    //Verificação se as vagas disponiveis são maiores que 0
    public int VagasDisponiveis
    {
        get => vagasDisponiveis;
        set
        {
            if (value < 0) //for menor que 0
            {
                Console.WriteLine("O número de vagas não pode ser menor que 0.");
            }
            vagasDisponiveis = value;
        }
    }
    //Construtot de PacoteTuristico
    public PacoteTuristico(string codigo, string descricao, Destino destino, DateTime dateTimeInicio, DateTime dateTimeFim, decimal preco, int vagasDisponiveis, string nome) 
        : base(codigo, descricao) //Herda de ServicoViagem
    {
        Destino = destino;
        DateTimeInicio = dateTimeInicio;
        DateTimeFim = dateTimeFim;
        Preco = preco;
        VagasDisponiveis = vagasDisponiveis;
        Nome = nome;
    }
    
    //Verificação se existe vagas e se tiver sera feita a reserva
    public override void Reservar() 
    {
        if (VagasDisponiveis > 0)//se tiver vagas disponiveis
        {
            VagasDisponiveis--;
            Console.WriteLine("Reserva realizada com sucesso.");
        }
        else
        {
            Console.WriteLine("Não há vagas disponíveis.");
        }
    }
    
    //Cancelando reserva
    public override void Cancelar()//é responsável por cancelar uma reserva e liberar uma vaga que estava ocupada
    {
        VagasDisponiveis++;
        Console.WriteLine("Reserva cancelada com sucesso.");
    }

    public object PesquisarPorCodigo(string codigo)
    {
        if (Codigo == codigo) //Verificar e comparar se o código do objeto atual é o mesmo que o código que está sendo pesquisado
        {
            return this;
        }
        return null;
    }

    public object PesquisarPorNome(string nome)
    {
        if (Descricao.Contains(nome, StringComparison.OrdinalIgnoreCase))//busca um objeto com base no nome (ou descrição) em vez de um código
        {
            return this;
        }
        return null;
    }

    public string Detalhes()
    {
        return $"Pacote: {Nome}, Código: {Codigo}, Destino: {Destino.Nome}, Descrição: {Descricao}, Vagas Disponíveis: {VagasDisponiveis}";
    }
}
