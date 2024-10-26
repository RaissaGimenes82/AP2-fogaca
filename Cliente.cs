//Inicialização da classe cliente
public class Cliente
{
    internal object Codigo { get; set; }

    public string Nome { get; set; }

    public int NumeroIdentificacao { get; set; }  

    public int Contato { get; private set; }
    //Construtores
    public Cliente(string nome, int numeroIdentificacao, int contato)
    {
        Nome = nome;
        NumeroIdentificacao = numeroIdentificacao; 
        Contato = contato;
    }
    
    //Exibição de informações
    public void ExibirInformacoes()
    {
        Console.WriteLine($"Seu nome é: {Nome}, seu Número de Identificação é: {NumeroIdentificacao}, e seu Contato é: {Contato}");
    }
    //Exibição de detalhes
    public string Detalhes()
    {
        return $"Cliente: {Nome}, Número de Identificação: {NumeroIdentificacao}, Contato: {Contato}";
    }
}
