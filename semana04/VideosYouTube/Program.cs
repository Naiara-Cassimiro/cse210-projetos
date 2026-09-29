using System;

class Program
{
    static void Main(string[] args)
    {
        Video video1 = new Video(
            "Aprendendo C#",
            "Canal Programação",
            300
        );

        video1.AdicionarComentario(
            new Comentario("Ana", "Gostei muito da explicação!")
        );

        video1.AdicionarComentario(
            new Comentario("Carlos", "O vídeo me ajudou bastante.")
        );

        video1.AdicionarComentario(
            new Comentario("Mariana", "Muito fácil de entender!")
        );

        Video video2 = new Video(
            "Introdução à Programação",
            "Estudar Tecnologia",
            420
        );

        video2.AdicionarComentario(
            new Comentario("João", "Ótimo conteúdo!")
        );

        video2.AdicionarComentario(
            new Comentario("Beatriz", "Estou começando a aprender programação.")
        );

        video2.AdicionarComentario(
            new Comentario("Lucas", "Explicação muito boa.")
        );

        Video video3 = new Video(
            "Programação Orientada a Objetos",
            "Mundo da Tecnologia",
            600
        );

        video3.AdicionarComentario(
            new Comentario("Fernanda", "Agora entendi melhor sobre classes.")
        );

        video3.AdicionarComentario(
            new Comentario("Pedro", "Muito interessante!")
        );

        video3.AdicionarComentario(
            new Comentario("Juliana", "Gostei dos exemplos apresentados.")
        );

        List<Video> videos = new List<Video>();

        videos.Add(video1);
        videos.Add(video2);
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine($"Título: {video.GetTitulo()}");
            Console.WriteLine($"Autor: {video.GetAutor()}");
            Console.WriteLine($"Duração: {video.GetDuracao()} segundos");
            Console.WriteLine($"Número de comentários: {video.GetNumeroComentarios()}");

            Console.WriteLine("Comentários:");

            foreach (Comentario comentario in video.GetComentarios())
            {
                Console.WriteLine($"- {comentario.GetNomePessoa()}: {comentario.GetTexto()}");
            }

            Console.WriteLine();
        }
    }
}