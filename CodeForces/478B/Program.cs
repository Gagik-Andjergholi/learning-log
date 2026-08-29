long[] a = Console.ReadLine().Split(' ').Select(long.Parse).ToArray();
long n = a[0], m = a[1], ans = 0;
long c(long x)
{
    return (x - 1) * x / 2;
}
ans = (n % m) * c(n / m + 1) + (m - n % m) * c(n / m);
Console.WriteLine(ans + " " + c(n - m + 1));