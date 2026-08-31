string s1 = Console.ReadLine();
string s2 = Console.ReadLine();
string s3 = Console.ReadLine();
s1 += s2;
char[] c1 = s1.ToCharArray();
char[] c2 = s3.ToCharArray();
Array.Sort(c1);
Array.Sort(c2);
s1 = new string(c1);
s3 = new string(c2);
if(s1 == s3)
    System.Console.WriteLine("YES");
else
    System.Console.WriteLine("NO");