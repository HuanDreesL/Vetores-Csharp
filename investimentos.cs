double CalcularTotal (double[,] carteira)
{
    double total = 0;
    for (int i = 0; i < carteira.GetLength(0); i++)
    {
        double quantidade = carteira[i, 0];
        double precoAtual = carteira[i, 1];

        total += quantidade * precoAtual;
    }
    return total;
}
double[,] carteira =
{
    { 100, 50.00},
    { 200, 1000.00 },
    { 5000, 10.50},
};

double valorTotal = CalcularTotal(carteira);
Console.WriteLine($"Total de investimentos é: {valorTotal:C}");
