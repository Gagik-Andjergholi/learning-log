int t = int.Parse(Console.ReadLine());
int n, ans, cnt;
while(t-- > 0)
{
    n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    ans = 0; cnt = 0;
    for(int i = 0; i < n; i++)
    {
        if(a[i] == 0)
        {
            cnt++;
            ans = Math.Max(ans, cnt);
            continue;
        }
        cnt = 0;
    }
    System.Console.WriteLine(ans);
}