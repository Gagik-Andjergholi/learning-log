int t = int.Parse(Console.ReadLine());
string[] trash = new string[2];
int n;
char c;
while(t-- > 0)
{
    trash = Console.ReadLine().Split(' ').ToArray();
    n = int.Parse(trash[0]);
    int ans = 0;
    string s = Console.ReadLine();
    for(int i = 0; i < s.Length / 2; i++)
    {
        if(i == n - 1 - i)
        {
            break;
        }
        if(i - (n - 1 - i) == 1)
        {
            break;
        }
        if(s[i] == s[n - 1 - i])
        {
            continue;
        }
        if(s[i] == trash[1][0] || s[n - i - 1] == trash[1][0])
        {
            ans++;
            continue;
        }
        ans += 2;
    }
    System.Console.WriteLine(ans);
}


/*
int t = int.Parse(Console.ReadLine());
int[] trash = new int[2];
int n, k;
while(t-- > 0)
{
    trash = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    (n, k) = (trash[0], trash[1]);
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
}
*/