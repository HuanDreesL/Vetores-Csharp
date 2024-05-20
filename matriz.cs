using System.Text.Json.Serialization;

int[,] matriz = { { 1, 2 }, { 3, 4 }, {5, 6} };

for (int i = 0; i < matriz.GetLength(0); i++)
{
    for (int j = 0; j < matriz.GetLength(1); j++)
    {
        Console.WriteLine(matriz[i, j]);
    }
}
