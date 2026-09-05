using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numero = -1;

while (numero != 0)
{
    Console.Write("Insira o número: ");
    numero = int.Parse(Console.ReadLine());

    if (numero != 0)
    {
        numeros.Add(numero);
    }
}

    int soma = 0;

foreach (int valor in numeros)
{
    soma += valor;
}

Console.WriteLine($"A soma é: {soma}");

double media = (double)soma / numeros.Count;

Console.WriteLine($"A média é: {media}");

int maior = numeros[0];

foreach (int valor in numeros)
{
    if (valor > maior)
    {
        maior = valor;
    }
}

Console.WriteLine($"O maior número é: {maior}");

}

}