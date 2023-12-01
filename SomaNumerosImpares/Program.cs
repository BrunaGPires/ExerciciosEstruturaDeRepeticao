int[] numeros = Enumerable.Range(1, 500).ToArray();
int[] impares = FiltroImpares(numeros);

Console.WriteLine("\nNumeros ímpares múltiplos de três: ");
foreach (int num in impares)
{
    Console.Write(num + " ");
}

Console.WriteLine("\n\nA soma dos números ímpares múltiplos de três de 1 a 500 é: " + SomaImpares(impares));

int[] FiltroImpares (int[] numeros)
{
    var filtrados = new List<int>();
    foreach (int num in numeros)
    {
        if (num % 2 != 0 && num % 3 == 0)
        {
            filtrados.Add(num);
        }
    }
    return filtrados.ToArray();
}

int SomaImpares (int[] impares)
{
    int soma = 0;
    foreach (int valor in impares)
    {
        soma += valor;
    }
    return soma;
}