int t = int.Parse(Console.ReadLine());
int n, o;
while(t-- > 0)
{
    n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    o = 0;
    foreach(var x in a)
        o += x % 2;
    System.Console.WriteLine(o % 2 == 0 ? "YES" : "NO");
}