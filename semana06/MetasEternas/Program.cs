using System;

class Program
{
    static void Main(string[] args)
    {
        // CRIATIVIDADE:
        // Foi adicionado um sistema de gamificação com níveis baseados
        // na pontuação do jogador: Iniciante, Aprendiz, Experiente e Mestre.
        // O programa também informa quantos pontos faltam para alcançar
        // o próximo nível, incentivando o usuário a continuar cumprindo suas metas.

        GerenciadorDeMetas gerenciador = new GerenciadorDeMetas();
        gerenciador.Iniciar();
    }
}