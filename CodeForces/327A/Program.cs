int n = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] dp = new int[n];
int[] psum = new int[n];
psum[0] = a[0];
for(int i = 1; i < n; i++)
{
    psum[i] = psum[i - 1] + a[i];
}

int f(int l, int r)
{
    int ones = psum[r];
    if(l > 0)
        ones -= psum[l - 1];
    return r - l + 1 - 2 * ones;
}
if(psum[n - 1] == n)
{
    System.Console.WriteLine(n - 1);
    return 0;
}
dp[0] = 1;
for(int i = 1; i < n; i++)
{
    dp[i] = dp[i - 1] + a[i];
    for(int j = 0; j <= i; j++)
    {
        // System.Console.WriteLine($"i : {i}\t, j : {j}\t, switch({i - j}, {i}) : {psum[i] + f(i - j, i)}");
        dp[i] = Math.Max(dp[i], psum[i] + f(i - j, i));
    }
}

System.Console.WriteLine(dp[n - 1]);
return 0;