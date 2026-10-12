int t = int.Parse(Console.ReadLine());
int n, q;
while(t-- > 0)
{
    int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    (n, q) = (input[0], input[1]);
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int[] pref = new int[n + 1];
    pref[0] = a[0];
    for(int i = 1; i < n; i++)
    {
        pref[i] = a[i] + pref[i - 1];
    }
    pref[n] = pref[n - 1];
    for(int i = 0; i < q; i++)
    {
        int[] cin = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        cin[0]--; cin[1]--;
        int x = (cin[1] - cin[0] + 1) % 2 * cin[2] % 2;
        x += cin[0] == 0 ? 0 : pref[cin[0] - 1];
        x %= 2;
        x += pref[n] - pref[cin[1]];
        x %= 2;
        System.Console.WriteLine(x == 0 ? "NO" : "YES");
    }
}