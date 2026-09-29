public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double CalcularCustoTotal()
    {
        double total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.GetCustoTotal();
        }

        if (_cliente.MoraNosEUA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string GerarEtiquetaEmbalagem()
    {
        string etiqueta = "";

        foreach (Produto produto in _produtos)
        {
            etiqueta += $"{produto.GetNome()} - {produto.GetIdProduto()}\n";
        }

        return etiqueta;
    }

    public string GerarEtiquetaEnvio()
    {
        return $"{_cliente.GetNome()}\n{_cliente.GetEndereco().GetEnderecoCompleto()}";
    }
}