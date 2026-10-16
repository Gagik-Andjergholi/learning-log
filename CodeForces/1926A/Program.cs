int t = int.Parse(Console.ReadLine());
string s;
while(t-- > 0)
{
    s = Console.ReadLine();
    int cnt = 0;
    char c = ' ';
    for(int i = 0; i < s.Length; i++)
    {
        if(cnt == 0)
        {
            c = s[i];
        }
        if(s[i] == c)
        {
            cnt++;
        }
        else
        {
            cnt--;
        }
    }
    System.Console.WriteLine(c);
}