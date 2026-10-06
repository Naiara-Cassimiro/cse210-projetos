using System;

class Program
{
    static void Main(string[] args)
    {
        Corrida corrida = new Corrida("03 Nov 2022", 30, 4.8);
        Ciclismo ciclismo = new Ciclismo("03 Nov 2022", 30, 20.0);
        Natacao natacao = new Natacao("03 Nov 2022", 30, 20);

        List<Atividade> atividades = new List<Atividade>();

        atividades.Add(corrida);
        atividades.Add(ciclismo);
        atividades.Add(natacao);

        foreach (Atividade atividade in atividades)
        {
            Console.WriteLine(atividade.ObterResumo());
        }
    }
}