public class Diario
{
    public List<Entrada> _entradas = new List<Entrada>();

    public void AdicionarEntrada(Entrada novaEntrada)
    {
        _entradas.Add(novaEntrada);
    }

    public void ExibirTodos()
    {
        foreach (Entrada entrada in _entradas)
        {
            entrada.Exibir();
        }
    }

    public void SalvarNoArquivo(string nomeArquivo)
    {
        using (StreamWriter arquivoSaida = new StreamWriter(nomeArquivo))
        {
            foreach (Entrada entrada in _entradas)
            {
                arquivoSaida.WriteLine(
                    $"{entrada._data}|{entrada._textoPergunta}|{entrada._textoResposta}"
                );
            }
        }
    }

    public void CarregarDoArquivo(string nomeArquivo)
    {
        _entradas.Clear();

        string[] linhas = System.IO.File.ReadAllLines(nomeArquivo);

        foreach (string linha in linhas)
        {
            string[] partes = linha.Split('|');

            Entrada entrada = new Entrada();

            entrada._data = partes[0];
            entrada._textoPergunta = partes[1];
            entrada._textoResposta = partes[2];

            AdicionarEntrada(entrada);
        }
    }
}