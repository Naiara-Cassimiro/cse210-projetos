using System;

class Program
{
    static void Main(string[] args)
    {
        // Para ir além dos requisitos, adicionei um campo de humor a cada
        // entrada do diário. O humor é exibido, salvo no arquivo e carregado
        // novamente junto com as outras informações da entrada.

        Diario diario = new Diario();
        GeradorDePerguntas gerador = new GeradorDePerguntas();

        int opcao = 0;

        while (opcao != 5)
        {
            Console.WriteLine("Menu:");
            Console.WriteLine("1. Escrever");
            Console.WriteLine("2. Exibir");
            Console.WriteLine("3. Salvar");
            Console.WriteLine("4. Carregar");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string escolha = Console.ReadLine();

            if (!int.TryParse(escolha, out opcao))
            {
                Console.WriteLine("Por favor, digite uma opção válida.");
                Console.WriteLine();
                continue;
            }

            if (opcao == 1)
            {
                string pergunta = gerador.ObterPerguntaAleatoria();

                Console.WriteLine(pergunta);
                Console.Write("> ");
                string resposta = Console.ReadLine();

                Console.Write("Como você está se sentindo hoje? ");
                string humor = Console.ReadLine();

                Entrada novaEntrada = new Entrada();

                novaEntrada._data = DateTime.Now.ToShortDateString();
                novaEntrada._textoPergunta = pergunta;
                novaEntrada._textoResposta = resposta;
                novaEntrada._humor = humor;

                diario.AdicionarEntrada(novaEntrada);
            }
            else if (opcao == 2)
            {
                diario.ExibirTodos();
            }
            else if (opcao == 3)
            {
                Console.Write("Qual é o nome do arquivo? ");
                string nomeArquivo = Console.ReadLine();

                diario.SalvarNoArquivo(nomeArquivo);

                Console.WriteLine("Diário salvo.");
            }
            else if (opcao == 4)
            {
                Console.Write("Qual é o nome do arquivo? ");
                string nomeArquivo = Console.ReadLine();

                diario.CarregarDoArquivo(nomeArquivo);

                Console.WriteLine("Diário carregado.");
            }
            else if (opcao == 5)
            {
                Console.WriteLine("Até logo!");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }

            Console.WriteLine();
        }
    }
}