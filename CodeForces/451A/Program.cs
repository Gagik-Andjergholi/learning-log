int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
System.Console.WriteLine(Math.Min(a[0], a[1]) % 2 == 0 ? "Malvika" : "Akshat");