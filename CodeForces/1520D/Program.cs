using System.Runtime.InteropServices.Marshalling;

int t = int.Parse(Console.ReadLine());
int n;
long ans;
int[] cnt = new int[600100];
while(t-- > 0){
    n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Array.Fill(cnt, 0);
    for(int i = 0; i < n; i++)
    {
        cnt[a[i] - i >= 0 ? a[i] - i : a[i] - i + 500050]++;
    }
    ans = 0;
    for(int i = 0; i <= n + 10; i++)
    {
        ans += (long)cnt[i] * (long)(cnt[i] - 1) / 2;
        ans += (long)cnt[500050 - i] * (long)(cnt[500050 - i] - 1) / 2;
    }
    System.Console.WriteLine(ans);
}