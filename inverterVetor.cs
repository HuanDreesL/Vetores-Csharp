int[] Inverso(int[] v)
{
    for (int i = 0; i < v.Length / 2; i++)
    {
        int aux = v[i];
        v[i] = v[v.Length - 1 - i];
        v[v.Length - 1 - i] = aux;
    }
    return v;
}

int[] a = new int[6];

for (int i = 0; i < a.Length; i++)
{
    Console.WriteLine($"Digite o valor {i + 1}: ");
    a[i] = int.Parse( Console.ReadLine() );
}

a = Inverso(a);

foreach (int i in a)
{
    Console.WriteLine(i);
}
