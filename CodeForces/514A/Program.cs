string s = Console.ReadLine();
s = s.Replace('9', '0');
s = s.Replace('8', '1');
s = s.Replace('7', '2');
s = s.Replace('6', '3');
s = s.Replace('5', '4');
if (s.StartsWith('0'))
{
    s = s.Substring(1, s.Length - 1);
    s = '9' + s;
}
System.Console.WriteLine(s);