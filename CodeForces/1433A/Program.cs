int t = int.Parse(Console.ReadLine());
while(t-- > 0)
{
    int x = int.Parse(Console.ReadLine());
    int digits = x == 0 ? 1 : (int)Math.Log10(x) + 1;
    int ans = 10 * (x % 10 - 1);
    ans += digits * (digits + 1) / 2;
    System.Console.WriteLine(ans);
}