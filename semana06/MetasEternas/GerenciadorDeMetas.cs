public class GerenciadorDeMetas
{
    private List<Meta> _metas;
    private int _pontos;

    public GerenciadorDeMetas()
    {
        _metas = new List<Meta>();
        _pontos = 0;
    }

    public void Iniciar()
    {
        int opcao = 0;

        while (opcao != 6)
        {
            Console.WriteLine();
            ExibirInfoJogador();

            Console.WriteLine();
            Console.WriteLine("Menu de Opções:");
            Console.WriteLine("  1. Criar nova meta");
            Console.WriteLine("  2. Listar metas");
            Console.WriteLine("  3. Salvar metas");
            Console.WriteLine("  4. Carregar metas");
            Console.WriteLine("  5. Registrar evento");
            Console.WriteLine("  6. Sair");

            Console.Write("Selecione uma opção do menu: ");

            if (!int.TryParse(Console.ReadLine(), out opcao))
            {
                Console.WriteLine("Opção inválida. Digite um número de 1 a 6.");
                continue;
            }

            if (opcao == 1)
            {
                CriarMeta();
            }
            else if (opcao == 2)
            {
                ListarDetalhesDasMetas();
            }
            else if (opcao == 3)
            {
                SalvarMetas();
            }
            else if (opcao == 4)
            {
                CarregarMetas();
            }
            else if (opcao == 5)
            {
                RegistrarEvento();
            }
        }
    }

    public void ExibirInfoJogador()
    {
        string nivel;

        if (_pontos >= 1000)
        {
            nivel = "Mestre";
        }
        else if (_pontos >= 500)
        {
            nivel = "Experiente";
        }
        else if (_pontos >= 200)
        {
            nivel = "Aprendiz";
        }
        else
        {
            nivel = "Iniciante";
        }

        Console.WriteLine($"Você tem {_pontos} pontos.");
        Console.WriteLine($"Nível atual: {nivel}");
    }

    public void ListarNomesDasMetas()
    {
        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterNome()}");
        }
    }

    public void ListarDetalhesDasMetas()
    {
        Console.WriteLine("As metas são:");

        for (int i = 0; i < _metas.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_metas[i].ObterDetalhesEmTexto()}");
        }
    }

    public void CriarMeta()
    {
        Console.WriteLine("Os tipos de metas são:");
        Console.WriteLine("  1. Meta Simples");
        Console.WriteLine("  2. Meta Eterna");
        Console.WriteLine("  3. Meta de Lista de Tarefas");

        Console.Write("Qual tipo de meta você gostaria de criar? ");
        string tipo = Console.ReadLine();

        Console.Write("Qual é o nome da sua meta? ");
        string nome = Console.ReadLine();

        Console.Write("Qual é uma breve descrição dela? ");
        string descricao = Console.ReadLine();

        Console.Write("Quantos pontos estão associados a essa meta? ");
        int pontos = int.Parse(Console.ReadLine());

        if (tipo == "1")
        {
            MetaSimples meta = new MetaSimples(nome, descricao, pontos);
            _metas.Add(meta);
        }
        else if (tipo == "2")
        {
            MetaEterna meta = new MetaEterna(nome, descricao, pontos);
            _metas.Add(meta);
        }
        else if (tipo == "3")
        {
            Console.Write("Quantas vezes essa meta precisa ser realizada para receber o bônus? ");
            int total = int.Parse(Console.ReadLine());

            Console.Write("Qual é o bônus por completar essa meta? ");
            int bonus = int.Parse(Console.ReadLine());

            MetaDeListaDeTarefas meta =
                new MetaDeListaDeTarefas(nome, descricao, pontos, total, bonus);

            _metas.Add(meta);
        }
    }

    public void RegistrarEvento()
    {
        Console.WriteLine("As metas são:");
        ListarNomesDasMetas();

        Console.Write("Qual meta você realizou? ");
        int escolha = int.Parse(Console.ReadLine());

        Meta metaEscolhida = _metas[escolha - 1];

        if (metaEscolhida.EstaConcluida())
        {
            Console.WriteLine("Essa meta já foi concluída.");
            return;
        }

        metaEscolhida.RegistrarEvento();

        _pontos += metaEscolhida.ObterPontos();

        if (metaEscolhida is MetaDeListaDeTarefas metaLista)
        {
            if (metaLista.ObterConcluidas() == metaLista.ObterTotal())
            {
                _pontos += metaLista.ObterBonus();

                Console.WriteLine(
                    $"Você completou a lista e ganhou um bônus de {metaLista.ObterBonus()} pontos!");
            }
        }

        Console.WriteLine(
            $"Parabéns! Você ganhou {metaEscolhida.ObterPontos()} pontos!");
    }

    public void SalvarMetas()
    {
        Console.Write("Qual é o nome do arquivo? ");
        string nomeArquivo = Console.ReadLine();

        using (StreamWriter arquivo = new StreamWriter(nomeArquivo))
        {
            arquivo.WriteLine(_pontos);

            foreach (Meta meta in _metas)
            {
                arquivo.WriteLine(meta.ObterRepresentacaoEmTexto());
            }
        }
    }

    public void CarregarMetas()
    {
        Console.Write("Qual é o nome do arquivo? ");
        string nomeArquivo = Console.ReadLine();

        string[] linhas = File.ReadAllLines(nomeArquivo);

        _pontos = int.Parse(linhas[0]);

        _metas.Clear();

        for (int i = 1; i < linhas.Length; i++)
        {
            string[] partesTipo = linhas[i].Split(':');

            string tipo = partesTipo[0];
            string[] dados = partesTipo[1].Split('|');

            if (tipo == "MetaSimples")
            {
                string nome = dados[0];
                string descricao = dados[1];
                int pontos = int.Parse(dados[2]);
                bool estaConcluida = bool.Parse(dados[3]);

                MetaSimples meta =
                    new MetaSimples(nome, descricao, pontos, estaConcluida);

                _metas.Add(meta);
            }
            else if (tipo == "MetaEterna")
            {
                string nome = dados[0];
                string descricao = dados[1];
                int pontos = int.Parse(dados[2]);

                MetaEterna meta =
                    new MetaEterna(nome, descricao, pontos);

                _metas.Add(meta);
            }
            else if (tipo == "MetaDeListaDeTarefas")
            {
                string nome = dados[0];
                string descricao = dados[1];
                int pontos = int.Parse(dados[2]);
                int bonus = int.Parse(dados[3]);
                int total = int.Parse(dados[4]);
                int concluidas = int.Parse(dados[5]);

                MetaDeListaDeTarefas meta =
                    new MetaDeListaDeTarefas(
                        nome,
                        descricao,
                        pontos,
                        total,
                        bonus,
                        concluidas);

                _metas.Add(meta);
            }
        }
    }
}