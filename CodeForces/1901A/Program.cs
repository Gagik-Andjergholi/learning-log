using System.ComponentModel;

int t = int.Parse(Console.ReadLine());
int n, x, ans;
while(t-- > 0)
{
    int[] trash = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    n = trash[0]; x = trash[1];
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    ans = 0;

    for(int i = 0; i < n - 1; i++)
    {
        ans = Math.Max(ans, Math.Abs(a[i] -a[i + 1]));
    }
    ans = Math.Max(ans, Math.Abs(a[0]));
    ans = Math.Max(ans, 2 * Math.Abs(a[n - 1] - x));
    System.Console.WriteLine(ans);
}