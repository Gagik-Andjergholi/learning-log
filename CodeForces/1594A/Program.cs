using System;
int t = int.Parse(Console.ReadLine());
while(t-- > 0)
{
    long n = long.Parse(Console.ReadLine());
    var (a, b) = find(2 * n);
    Console.WriteLine(Math.Min(b + 1 - a / 2, b + a / 2) + " " + Math.Max(b + 1 - a / 2, b + a / 2));
}

Tuple<long, long> find(long n)
{
    long a = 1, b;
    while(n % 2 == 0)
    {
        n /= 2;
        a *= 2;
    }
    b = n / 2;
    return Tuple.Create(a, b);
}