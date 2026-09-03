int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
System.Console.WriteLine(Math.Min((int)Math.Floor((Math.Sqrt(1 + (double)8/5 * (240 - a[1])) - 1) / 2), a[0]));