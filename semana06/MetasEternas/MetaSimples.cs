public class MetaSimples : Meta
{
    private bool _estaConcluida;

    public MetaSimples(string nome, string descricao, int pontos)
        : base(nome, descricao, pontos)
    {
        _estaConcluida = false;
    }

    public MetaSimples(
        string nome,
        string descricao,
        int pontos,
        bool estaConcluida)
        : base(nome, descricao, pontos)
    {
        _estaConcluida = estaConcluida;
    }

    public override void RegistrarEvento()
    {
        _estaConcluida = true;
    }

    public override bool EstaConcluida()
    {
        return _estaConcluida;
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaSimples:{ObterNome()}|{ObterDescricao()}|{ObterPontos()}|{_estaConcluida}";
    }
}