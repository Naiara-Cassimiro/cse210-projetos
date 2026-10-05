public class AtividadeDeListagem : Atividade
{
    private List<string> _mensagens;

    public AtividadeDeListagem()
        : base(
            "Atividade de Listagem",
            "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área."
        )
    {
        _mensagens = new List<string>
        {
            "Quem são as pessoas que você aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são as pessoas que você ajudou esta semana?",
            "Quando você sentiu o Espírito Santo neste mês?",
            "Quem são alguns dos seus heróis pessoais?"
        };
    }

    private string ObterMensagemAleatoria()
    {
        Random random = new Random();
        int indice = random.Next(_mensagens.Count);

        return _mensagens[indice];
    }

    public void Executar()
    {
        ExibirMensagemInicial();
        ExibirSpinner(3);

        Console.WriteLine();
        Console.WriteLine("Liste o máximo de respostas que puder para a seguinte pergunta:");
        Console.WriteLine();
        Console.WriteLine($"--- {ObterMensagemAleatoria()} ---");
        Console.WriteLine();

        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);
        Console.WriteLine();
        Console.WriteLine();

        int quantidade = 0;
        DateTime horaFinal = DateTime.Now.AddSeconds(GetDuracao());

        while (DateTime.Now < horaFinal)
        {
            Console.Write("> ");
            Console.ReadLine();
            quantidade++;
        }

        Console.WriteLine();
        Console.WriteLine($"Você listou {quantidade} itens!");

        ExibirMensagemFinal();
    }
}