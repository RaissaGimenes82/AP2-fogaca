//Inicialização das nossas interfaces
public interface IPesquisavel
{
    object PesquisarPorCodigo(string codigo);
    object PesquisarPorNome(string nome);
}