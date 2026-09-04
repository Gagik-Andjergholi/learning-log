int[] arr = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Console.WriteLine(Math.Min(arr[0], arr[1]) + " " + (Math.Max(arr[0], arr[1]) - Math.Min(arr[0], arr[1])) / 2);