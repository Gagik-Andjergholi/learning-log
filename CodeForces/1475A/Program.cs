int t = int.Parse(Console.ReadLine());
while (t-- > 0)
{
    long n = long.Parse(Console.ReadLine());
    while (n % 2 == 0)
    {
        n /= 2;
    }
    Console.WriteLine((n== 1) ? "NO" : "YES");
}