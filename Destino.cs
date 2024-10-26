//Inicialização da classe Destino
public class Destino
{
    public string Nome { get; set; }
    public string Pais { get; set; }
    public string Codigo { get; set; }
    public string Descricao { get; set; }
   //Construtores
    public Destino(string nome, string pais, string codigo, string descricao)
    {
        Nome = nome;
        Pais = pais;
        Codigo = codigo;
        Descricao = descricao;
    }

    public string Detalhes()
    {
        return $"Destino: {Nome}, País: {Pais}, Código: {Codigo}, Descrição: {Descricao}";
    }


    
    public void  ExibirInformacoes()
    {
        Console.WriteLine($"Seu País é: {Pais}; seu Código é:{Codigo}, a Discrição é:{Descricao}");

        return;
    }
    
}
   
