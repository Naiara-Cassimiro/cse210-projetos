using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Provérbios", 3, 5, 6);

        Scripture scripture = new Scripture(reference,
            "Confia no Senhor de todo o teu coração, e não te estribes no teu próprio entendimento. " +
            "Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas.");

        Console.WriteLine(scripture.GetDisplayText());

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