int t = int.Parse(Console.ReadLine());
int[] trash = new int[2];
int n;
while(t-- > 0)
{
    int[] cnt = new int[110];
    List<int> ans = new List<int> {};

    n = int.Parse(Console.ReadLine());
    int[] tt = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    for(int i = 0; i < n; i++)
    {
        cnt[tt[i]]++;
    }

    int[] a = tt.Distinct().ToArray();
    Array.Sort(a);

    for(int i = a.Length - 1; i >= 0; i--)
    {
        for(int j = 0; j < cnt[a[i]]; j++)
        {
            ans.Add(a[i]);
        }
        for(int j = i - 1; j >= 0; j--)
        {
            for(int k = 0; k < Math.Min(cnt[a[i]], cnt[a[j]]); k++)
            {
                ans.Add(a[j]);    
            }
            cnt[a[j]] = Math.Max(0, cnt[a[j]] - cnt[a[i]]);
        }
    }
    System.Console.WriteLine(String.Join(' ', ans));
}