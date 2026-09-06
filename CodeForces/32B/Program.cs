string s = Console.ReadLine();
string ans = "";
for(int  i = 0; i < s.Length; i++)
{
    if(s[i] == '.')
    {
        ans += "0";
        continue;
    }
    if(s[i + 1] == '-')
    {
        ans += "2";
        i++;
        continue;
    }
    ans += "1";
    i++;
}
System.Console.WriteLine(ans);