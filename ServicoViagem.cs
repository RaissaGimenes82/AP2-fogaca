//Inicialização da classe ServicoViagem
public abstract class ServicoViagem
{
    public string Codigo {get; set; }

    protected string  Descricao {get; set; }

  //Construtores
    public ServicoViagem (string codigo, string descricao) 
    {
        Codigo = codigo;
        Descricao = descricao;
    }
    
//dois metodos sem implementação
    public abstract void Reservar();

    public abstract void Cancelar();
}