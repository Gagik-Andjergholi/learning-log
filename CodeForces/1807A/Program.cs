int t = int.Parse(Console.ReadLine());
while(t-- > 0)
{
    int[ ] a = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
    Console.WriteLine(a[0] + a[1] == a[2] ? "+" : "-");
}