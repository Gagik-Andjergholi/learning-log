int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int n = input[0];
bool[] dp = new bool[n];
dp[0] = true;
for(int i = 0; i < n - 1; i++)
    if (dp[i] && i + a[i] < n)
        dp[i + a[i]] = true;
System.Console.WriteLine(dp[input[1] - 1] ? "YES" : "NO");