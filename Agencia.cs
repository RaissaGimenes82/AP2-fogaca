//Inicialização da classe agencia e suas listas

public class Agencia
{
    public List<Destino> Destinos {get; set; }

    public List<Cliente> Clientes {get; set ;}

    public List<PacoteTuristico> Pacotes{get; set; }

    public List<Reserva> Reservas{get; set; } 

//Construtor de agencia, criando as listas vazias
    public Agencia()
    {
        Destinos = new List<Destino>();

        Clientes = new List<Cliente>();

        Pacotes = new List<PacoteTuristico>();

        Reservas = new List<Reserva>();
    }
    
    
    // criação dos destinos e verificação de nulos, duplicados e invalidos 
    public void CadastrarDestino(Destino destino)
    {
        if (destino != null && !Destinos.Contains(destino)) //verificação de nulo e verificação de !duplicidade
        {
            Destinos.Add(destino); //se for verdadeiro, o cadastro será adcionado
            Console.WriteLine("Destino cadastrado com sucesso.");
        }
        else
        {
            Console.WriteLine("Destino inválido ou já cadastrado.");
        }
    }

    //Procura um destino específico na lista Destinos usando o código que foi atribuido
    public Destino ConsultarDestinoPorCodigo(string codigo)
    {
    foreach (var destino in Destinos) //percorre cada destino criado
    {
        if (destino.Codigo == codigo) //verifica se o codigo fornecido é o mesmo que está sendo procurado
        {
            return destino;
        }
    }
    Console.WriteLine("Destino não encontrado.");
    return null; 
    }
    
    //Exibição dos destinos
    public void ListarDestinos()
    {
        foreach (var destino in Destinos) //Percorre cada destino da lista
        {
            Console.WriteLine(destino.Detalhes()); //Para cada destino encontrado na lista, o metodo detalhes sera chamado
        }
    }

    //Adição do cliente
    public void CadastrarCliente(Cliente cliente)
    {
        if (cliente != null && !Clientes.Contains(cliente)) //verificação se o cliente existe na lista clientes e se não é nulo
        {
            Clientes.Add(cliente); //se tudo der certo, é adicionado
            Console.WriteLine("Cliente cadastrado com sucesso.");
        }
        else
        {
            Console.WriteLine("Cliente inválido ou já cadastrado.");
        }
    }
    
    //Não adiciona, apenas busca pelo Id
    public Cliente ConsultarClientePorID(int numeroIdentificacao)
    {
        foreach (var cliente in Clientes) //percorre todos os clientes da lista
        {
            if (cliente.NumeroIdentificacao == numeroIdentificacao) //verifica se o cliente existe e se tem o mesmo numero de identificação fornecido
            {
                return cliente; //se der tudo certo aparece o cliente
            }
        }
        return null; //se não, retorna null
    }

    //Listagem de clientes

    public void ListarClientes()
    {
        foreach (var cliente in Clientes) //Percorre cada cliente da lista 
        {
            Console.WriteLine(cliente.Detalhes());//sempre chamando o metodo detalhes
        }
    }

    //Criação de Pacotes
    public void CadastrarPacote(PacoteTuristico pacote)
    {
        if (pacote != null && !Pacotes.Contains(pacote)) //Verifica se o Pacote é nulo e Verifica se a lista !Pacotes já não contém o pacote que está sendo cadastrado
        {
            Pacotes.Add(pacote);//Adiciona se der tudo certo
            Console.WriteLine("Pacote cadastrado com sucesso.");
        }
        else
        {
            Console.WriteLine("Pacote inválido ou já cadastrado.");
        }
    }
    
    //Procura o Pacote
    public PacoteTuristico ConsultarPacotePorCodigo(string codigo) //recebe um parâmetro do tipo string, chamado codigo, que é o código do pacote que ele vai consultar.
    {
    foreach (var pacote in Pacotes) //Percorre cada pacote da lista individualmente 
    {
        if (pacote.Codigo == codigo) // e se esse codigo que ele esta procurando existe 
    
        {
            return pacote;
        }
    }
    Console.WriteLine("Pacote não encontrado.");
    return null; // Retorna null se não encontrar
    }
     
    //Listagem de Pacote
    public void ListarPacotes()
    {
        foreach (var pacote in Pacotes)//Para percorrer todos os cacotes
        {
            Console.WriteLine(pacote.Detalhes()); //Percorre cada Pacote da lista sempre chamando o metodo detalhes
        }
    }
    
    //Reserva um pacote turístico para cada cliente específico
    public void ReservarPacote(string codigoPacote, Cliente cliente)//O código pre existente do pacote que o cliente deseja reservar e o cliente expecifico.
    {
        PacoteTuristico pacote = ConsultarPacotePorCodigo(codigoPacote);
        if (pacote != null && cliente != null && Pacotes.Contains(pacote))//Verifica se o cliente existe, se o pacote existe e se não é nulo
        {
            pacote.Reservar();
            Reserva reserva = new Reserva(cliente, pacote);//se der tudo certo a reserva é criada com o respectivo pacote e cliente
            Reservas.Add(reserva);
            Console.WriteLine("Pacote reservado com sucesso.");
        }
        else
        {
            Console.WriteLine("Pacote ou cliente inválido.");
        }
    }

    //Cancelamento de uma reserva expecifica
    public void CancelarReserva(string codigoReserva)
    {
    for (int i = 0; i < Reservas.Count; i++) //Entra em todas as reservas criadas
    {
        if (Reservas[i].Codigo == codigoReserva) //Verifica se o código da reserva na posição i é igual ao codigoReserva que foi fornecido
        {
            Reservas[i].Cancelar(); //Se for, vai cancelar a reserva encontrada
            Console.WriteLine("Reserva cancelada com sucesso.");
            Reservas.RemoveAt(i);//Remoção da reserva da lista
            return;//Evita que ele continue a procurar outras reservas após o cancelamento
        }
    }
    Console.WriteLine("Reserva não encontrada.");
    }
}