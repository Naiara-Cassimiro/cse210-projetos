// EXCEDE OS REQUISITOS:
// O programa registra quantas vezes cada atividade foi concluída
// durante a execução e apresenta um resumo ao usuário ao sair.

string opcao = "";

int totalRespiracao = 0;
int totalReflexao = 0;
int totalListagem = 0;

while (opcao != "4")
{
    Console.Clear();

    Console.WriteLine("Menu de Opções:");
    Console.WriteLine("  1. Iniciar atividade de respiração");
    Console.WriteLine("  2. Iniciar atividade de reflexão");
    Console.WriteLine("  3. Iniciar atividade de listagem");
    Console.WriteLine("  4. Sair");
    Console.WriteLine();

    Console.Write("Selecione uma opção do menu: ");
    opcao = Console.ReadLine();

    if (opcao == "1")
    {
        AtividadeDeRespiracao atividade = new AtividadeDeRespiracao();
        atividade.Executar();

        totalRespiracao++;
    }
    else if (opcao == "2")
    {
        AtividadeDeReflexao atividade = new AtividadeDeReflexao();
        atividade.Executar();

        totalReflexao++;
    }
    0
    else if (opcao == "3")
    {
        AtividadeDeListagem atividade = new AtividadeDeListagem();
        atividade.Executar();

        totalListagem++;
    }
    else if (opcao == "4")
    {
        Console.Clear();

        Console.WriteLine("Resumo das atividades realizadas:");
        Console.WriteLine();
        Console.WriteLine($"Respiração: {totalRespiracao}");
        Console.WriteLine($"Reflexão: {totalReflexao}");
        Console.WriteLine($"Listagem: {totalListagem}");
        Console.WriteLine();

        Console.WriteLine("Obrigado por utilizar o Programa de Introspecção!");
    }
    else
    {
        Console.WriteLine("Opção inválida. Tente novamente.");
        Thread.Sleep(2000);
    }
}
