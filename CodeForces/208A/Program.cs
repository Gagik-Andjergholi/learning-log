string s = Console.ReadLine();
string ans = "";
bool b = false;
for(int i = 0; i < s.Length; i++)
{
    if(b && i + 3 <= s.Length && s[i] == 'W' && s[i + 1] == 'U' && s[i + 2] == 'B')
    {
        ans += " ";
        b = false;
        i += 2;
        continue;
    }
    if(!b && i + 3 <= s.Length && s[i] == 'W' && s[i + 1] == 'U' && s[i + 2] == 'B')
    {
        i += 2;
        continue;
    }
    ans += s[i];
    b = true;
}
System.Console.WriteLine(ans);