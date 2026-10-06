public abstract class Atividade
{
    private string _data;
    private int _duracao;

    public Atividade(string data, int duracao)
    {
        _data = data;
        _duracao = duracao;
    }

    public int ObterDuracao()
    {
        return _duracao;
    }

    public abstract double ObterDistancia();

    public abstract double ObterVelocidade();

    public abstract double ObterRitmo();

    public abstract string ObterNomeAtividade();

    public virtual string ObterResumo()
    {
        return $"{_data} {ObterNomeAtividade()} ({_duracao} min) - " +
               $"Distância {ObterDistancia():F1} km, " +
               $"Velocidade {ObterVelocidade():F1} km/h, " +
               $"Ritmo: {ObterRitmo():F1} min por km";
    }
}