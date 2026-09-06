int x = int.Parse(Console.ReadLine());
int ans = 0, k = 2;
while(x > 0)
{
    ans += x % 2;
    x /= 2;
}
System.Console.WriteLine(ans);