bool[] p = new bool[1000050];
Array.Fill(p, true);
p[0] = p[1] = false;
for(int i = 2; i <= 1000040; i++)
{
    if (p[i])
    {
        for(int j = 2 * i; j < 1000040; j += i)
        {
            p[j] = false;
        }
    }
}

int n = int.Parse(Console.ReadLine());
long[] a = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
for(int i = 0; i < n; i++)
{
    double sqrt = Math.Sqrt(a[i]);
    if (Math.Floor(sqrt) == sqrt && p[(int)sqrt])
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}