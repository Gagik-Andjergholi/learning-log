int[] vals = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int n = vals[0], a = vals[1], b = vals[2], c = vals[3];

int[] dp = new int[n + 5];
Array.Fill(dp, 0);
dp[0] = 1;
for(int i = Math.Min(a, Math.Min(b, c)); i <= n; i++)
{
    dp[i] = Math.Max(i >= a && dp[i - a] > 0 ? dp[i - a] + 1 : 0,
            Math.Max(i >= b && dp[i - b] > 0 ? dp[i - b] + 1 : 0,
                     i >= c && dp[i - c] > 0 ? dp[i - c] + 1 : 0));
}
Console.WriteLine(dp[n] - 1);