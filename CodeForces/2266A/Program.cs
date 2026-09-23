int t = int.Parse(Console.ReadLine());
int n;
while(t-- > 0)
{
    n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    System.Console.WriteLine(n - Math.Min(a[0], Math.Min(a[1], a[2])));
}