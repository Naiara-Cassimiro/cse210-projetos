public class MetaDeListaDeTarefas : Meta
{
    private int _concluidas;
    private int _total;
    private int _bonus;

    public MetaDeListaDeTarefas(
        string nome,
        string descricao,
        int pontos,
        int total,
        int bonus)
        : base(nome, descricao, pontos)
    {
        _concluidas = 0;
        _total = total;
        _bonus = bonus;
    }

    public MetaDeListaDeTarefas(
        string nome,
        string descricao,
        int pontos,
        int total,
        int bonus,
        int concluidas)
        : base(nome, descricao, pontos)
    {
        _concluidas = concluidas;
        _total = total;
        _bonus = bonus;
    }

    public int ObterBonus()
    {
        return _bonus;
    }

    public int ObterConcluidas()
    {
        return _concluidas;
    }

    public int ObterTotal()
    {
        return _total;
    }

    public override void RegistrarEvento()
    {
        _concluidas++;
    }

    public override bool EstaConcluida()
    {
        return _concluidas >= _total;
    }

    public override string ObterDetalhesEmTexto()
    {
        return base.ObterDetalhesEmTexto()
            + $" -- Atualmente concluída: {_concluidas}/{_total}";
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaDeListaDeTarefas:{ObterNome()}|{ObterDescricao()}|{ObterPontos()}|{_bonus}|{_total}|{_concluidas}";
    }
}