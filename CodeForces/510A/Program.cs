int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
string[] s = new string[4];
s[0] = string.Concat(Enumerable.Repeat("#", a[1]));
s[1] = string.Concat(Enumerable.Repeat(".", a[1] - 1));
(s[2], s[3]) = (s[0], s[1]);
(s[1] , s[3]) = (s[1] + '#', '#' + s[3]);
for(int i = 0; i < a[0]; i++)
    System.Console.WriteLine(s[i % 4]);