int[] trash = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int n = trash[0], k = trash[1];
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Array.Sort(a);
int ans = 0, t = 0;
while(t + 2 <= n - 1)
{
    if(a[t++] <= 5 - k && a[t++] <= 5 - k && a[t++] <= 5 - k)
    {
        ans++;
    }
    else
    {
        break;
    }
}
System.Console.WriteLine(ans);