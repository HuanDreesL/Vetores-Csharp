int[] BoobleSort(int[] v)
{
    for (int i = v.Length - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            if (v[j] > v[j + 1])
            {
                (v[j], v[j + 1]) = (v[j + 1], v[j]);
            }
        }
    }
    return v;
}

int[] ints = [7, 5, 10, 6, 8];
ints = BoobleSort(ints);

foreach(int i in ints)
{
    Console.WriteLine(i);
}
