int t = int.Parse(Console.ReadLine());
int n, ans;
string s;
int[] b = new int[26];
while(t-- > 0){
    n = int.Parse(Console.ReadLine());
    s = Console.ReadLine();
    for(int i = 0; i < 26; i++)
    {
        b[i] = 0;
    }
    for(int i = 0; i < n; i++)
    {
        b[s[i] - 'A']++;
    }
    ans = 0;
    for(int i = 0; i < 26; i++)
    {
        ans += (b[i] == 0 ? 0 : b[i] + 1);
    }
    System.Console.WriteLine(ans);
}