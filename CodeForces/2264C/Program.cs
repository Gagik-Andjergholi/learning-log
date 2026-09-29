int t = int.Parse(Console.ReadLine());
int n;
const int mod = 998244353;
long[] f = new long[200050];
(f[0], f[1]) = (1, 1);
for(int i = 2; i < 200050; i++)
{
    f[i] = i * f[i  - 1] % mod;
}
long pow(long x, int n)
{
    long resault = 1;

    while(n > 0)
    {
        if((n & 1) == 1)
        {
            resault = resault * x % mod;
        }
        x = x * x % mod;
        n >>= 1;
    }
    return resault;
}
while(t-- > 0)
{
    n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    long[] suf = new long[n];
    Array.Sort(a);
    suf[n - 1] = a[n - 1];
    for(int i = n - 2; i >= 0; i--)
    {
        suf[i] = suf[i + 1] + a[i];
    }
    long ans = 0;
    for(int i = 0; i < n - 1; i++)
    {
        long dif = (suf[i + 1] - (long)(n - i - 1) * a[i]) % mod;
        long y = f[n - 1] * pow(n - i - 1, mod - 2) % mod;
        y = y * dif % mod;
        ans = (ans + y) % mod;
    }
    System.Console.WriteLine(ans);
}