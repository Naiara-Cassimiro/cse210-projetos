public class Atividade
{
    private string _nome;
    private string _descricao;
    private int _duracao;

    public Atividade(string nome, string descricao)
    {
        _nome = nome;
        _descricao = descricao;
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"Bem-vindo à {_nome}.");
        Console.WriteLine();
        Console.WriteLine(_descricao);
        Console.WriteLine();

        Console.Write("Quanto tempo, em segundos, você gostaria de dedicar a esta atividade? ");
        _duracao = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Prepare-se para começar...");
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine();
        Console.WriteLine("Muito bem!");
        ExibirSpinner(2);

        Console.WriteLine();
        Console.WriteLine($"Você concluiu {_duracao} segundos da {_nome}.");
        ExibirSpinner(3);

        Console.WriteLine();
    }

    public void ExibirSpinner(int segundos)
    {
        List<string> simbolos = new List<string>
        {
            "|", "/", "-", "\\"
        };

        DateTime horaFinal = DateTime.Now.AddSeconds(segundos);
        int i = 0;

        while (DateTime.Now < horaFinal)
        {
            Console.Write(simbolos[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= simbolos.Count)
            {
                i = 0;
            }
        }
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetDuracao()
    {
        return _duracao;
    }
}