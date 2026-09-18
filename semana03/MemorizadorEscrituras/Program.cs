using System;

class Program
{
    static void Main(string[] args)
    {
        // Para ir além dos requisitos, criei uma pequena biblioteca de escrituras.
        // O programa escolhe aleatoriamente uma escritura para o usuário memorizar.

        List<Scripture> escrituras = new List<Scripture>();

        Reference reference = new Reference("Provérbios", 3, 5, 6);

        Scripture scripture = new Scripture(reference,
            "Confia no Senhor de todo o teu coração, e não te estribes no teu próprio entendimento. " +
            "Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas.");

        escrituras.Add(scripture);

        Reference reference2 = new Reference("Filipenses", 4, 13);

        Scripture scripture2 = new Scripture(reference2,
            "Posso todas as coisas em Cristo que me fortalece.");

        escrituras.Add(scripture2);

        Random random = new Random();
        scripture = escrituras[random.Next(escrituras.Count)];

        string entrada = "";

        while (entrada != "quit" && !scripture.IsCompletelyHidden())
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            Console.WriteLine();
            Console.WriteLine("Pressione Enter para continuar ou digite 'quit' para sair.");

            entrada = Console.ReadLine() ?? "";

            if (entrada != "quit")
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}