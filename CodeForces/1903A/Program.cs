int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    int[] x = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    if(x[1] != 1)
    {
        Console.WriteLine("YES");
        continue;
    }
    for(int i = 1; i < x[0]; i++)
    {
        if(a[i] < a[i - 1])
        {
            Console.WriteLine("NO");
            x[1] = -1;
            break;
        }
    }
    if(x[1] != -1)
    {
        Console.WriteLine("YES");
    }
}