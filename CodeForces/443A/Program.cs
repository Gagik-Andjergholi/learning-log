string s = Console.ReadLine();
s = s.Substring(1, s.Length - 2);
string[] ss = s.Split(", ");
ss = ss.Distinct().ToArray();
Console.WriteLine(ss[0] == "" ? 0 : ss.Length);