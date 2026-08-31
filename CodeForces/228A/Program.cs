int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
a = a.Distinct().ToArray();
System.Console.WriteLine(4 - a.Length);