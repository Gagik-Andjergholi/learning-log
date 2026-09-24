int t = int.Parse(Console.ReadLine());
int n, k = 0;
int[] trash = new int[2];
long[] dp = Array.Empty<long>();

List<int> p = new List<int> {};
const int N = 200050;
bool[] b = new bool[N];
int[] spf = new int[N];
for (int i = 2; i < N; i++)
{
    if (!b[i])
    {
        p.Add(i);
        spf[i] = i;

        for (int j = 2 * i; j < N; j += i)
        {
            b[j] = true;

            if (spf[j] == 0)
            {
                spf[j] = i;
            }
        }
    }
}

while (t-- > 0)
{
    trash = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    (n, k) = (trash[0], trash[1]);
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    long ans = 0;
    dp = new long[n + 1];
    Array.Fill(dp, -1L);

    for (int i = 0; i < n; i++)
    {
        ans += solve(a[i]);
    }

    Console.WriteLine(ans);
}

long solve(int x)
{
    if (x <= k)
        return 0;

    if (dp[x] != -1)
        return dp[x];

    long ans = long.MaxValue;
    int temp = x;

    while (temp > 1)
    {
        int q = spf[temp];

        ans = Math.Min(ans, 1L + (long)q * solve(x / q));
        while (temp % q == 0)
        {
            temp /= q;
        }
    }
    return dp[x] = ans;
}