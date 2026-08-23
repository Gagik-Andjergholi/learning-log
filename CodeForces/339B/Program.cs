string[] firstLine = Console.ReadLine().Split(' ');
long n, m, ans = 0;
n = long.Parse(firstLine[0]);
m = long.Parse(firstLine[1]);
int[] a = new[] { 1 }.Concat(Console.ReadLine().Split(' ').Select(int.Parse)).ToArray();
for(int i = 0; i < m; i++)
{
    ans += (a[i] <= a[i + 1]) ? a[i + 1] - a[i] : n + a[i + 1] - a[i];
}
Console.WriteLine(ans);