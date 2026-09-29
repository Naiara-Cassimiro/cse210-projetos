using System;

class Program
{
    static void Main(string[] args)
    {
        Endereco endereco1 = new Endereco(
            "123 Main Street",
            "Orlando",
            "Florida",
            "USA"
        );

        Cliente cliente1 = new Cliente(
            "John Smith",
            endereco1
        );

        Produto produto1 = new Produto(
            "Notebook",
            "P001",
            800.00,
            1
        );

        Produto produto2 = new Produto(
            "Mouse",
            "P002",
            25.00,
            2
        );

        Pedido pedido1 = new Pedido(cliente1);

        pedido1.AdicionarProduto(produto1);
        pedido1.AdicionarProduto(produto2);

        Endereco endereco2 = new Endereco(
            "Rua das Flores, 100",
            "São Paulo",
            "SP",
            "Brazil"
        );

        Cliente cliente2 = new Cliente(
            "Maria Silva",
            endereco2
        );

        Produto produto3 = new Produto(
            "Teclado",
            "P003",
            50.00,
            1
        );

        Produto produto4 = new Produto(
            "Fone de Ouvido",
            "P004",
            40.00,
            2
        );

        Pedido pedido2 = new Pedido(cliente2);

        pedido2.AdicionarProduto(produto3);
        pedido2.AdicionarProduto(produto4);

        Console.WriteLine("PEDIDO 1");
        Console.WriteLine();

        Console.WriteLine("Etiqueta de Embalagem:");
        Console.WriteLine(pedido1.GerarEtiquetaEmbalagem());

        Console.WriteLine("Etiqueta de Envio:");
        Console.WriteLine(pedido1.GerarEtiquetaEnvio());

        Console.WriteLine();
        Console.WriteLine($"Custo Total: ${pedido1.CalcularCustoTotal():F2}");

        Console.WriteLine();
        Console.WriteLine("--------------------");
        Console.WriteLine();

        Console.WriteLine("PEDIDO 2");
        Console.WriteLine();

        Console.WriteLine("Etiqueta de Embalagem:");
        Console.WriteLine(pedido2.GerarEtiquetaEmbalagem());

        Console.WriteLine("Etiqueta de Envio:");
        Console.WriteLine(pedido2.GerarEtiquetaEnvio());

        Console.WriteLine();
        Console.WriteLine($"Custo Total: ${pedido2.CalcularCustoTotal():F2}");
    }
}