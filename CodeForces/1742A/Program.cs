int t = int.Parse(Console.ReadLine());
for(int i = 0; i < t; i++)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    if(a[0] + a[1] == a[2] || a[1] + a[2] == a[0] || a[0] + a[2] == a[1])
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}