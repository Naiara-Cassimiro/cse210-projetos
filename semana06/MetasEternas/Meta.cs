public abstract class Meta
{
    private string _nome;
    private string _descricao;
    private int _pontos;

    public Meta(string nome, string descricao, int pontos)
    {
        _nome = nome;
        _descricao = descricao;
        _pontos = pontos;
    }

    public int ObterPontos()
    {
        return _pontos;
    }

    public string ObterNome()
    {
        return _nome;
    }

    public string ObterDescricao()
    {
        return _descricao;
    }

    public virtual string ObterDetalhesEmTexto()
    {
        string caixa = EstaConcluida() ? "[X]" : "[ ]";

        return $"{caixa} {_nome} ({_descricao})";
    }

    public abstract void RegistrarEvento();

    public abstract bool EstaConcluida();

    public abstract string ObterRepresentacaoEmTexto();
}