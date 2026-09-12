public class GeradorDePerguntas
{
    public List<string> _perguntas = new List<string>
    {
        "Qual foi a melhor parte do meu dia?",
        "O que aprendi hoje?",
        "Quem fez diferença no meu dia hoje?",
        "Por qual coisa sou grato hoje?",
        "O que eu gostaria de fazer melhor amanhã?"
    };

    public string ObterPerguntaAleatoria()
    {
        Random random = new Random();

        int indice = random.Next(_perguntas.Count);

        return _perguntas[indice];
    }
}