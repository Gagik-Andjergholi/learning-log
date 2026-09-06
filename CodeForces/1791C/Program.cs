int t = int.Parse(Console.ReadLine());
int n, l, r;
string s;
while(t-- > 0){
    n = int.Parse(Console.ReadLine());
    s = Console.ReadLine();
    l = 0; r = n - 1;
    while(l < r && s[l] != s[r])
    {
        l++; r--; continue;
    }
    System.Console.WriteLine(r - l + 1);
}