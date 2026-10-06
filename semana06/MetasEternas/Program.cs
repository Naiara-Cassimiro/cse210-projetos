using System;

class Program
{
    static void Main(string[] args)
    {
        // CRIATIVIDADE:
        // Foi adicionado um sistema de níveis baseado na pontuação do jogador.
        // Conforme os pontos aumentam, o jogador pode avançar pelos níveis
        // Iniciante, Aprendiz, Experiente e Mestre.

        GerenciadorDeMetas gerenciador = new GerenciadorDeMetas();
        gerenciador.Iniciar();
    }
}