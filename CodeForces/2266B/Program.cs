int t = int.Parse(Console.ReadLine());
while(t-- > 0)
{
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    System.Console.WriteLine(Math.Max(Math.Abs(a[0] + a[2] - a[1]), Math.Abs(a[0] - a[1])));
    
}