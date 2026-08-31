int n = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Array.Sort(a);
System.Console.WriteLine(String.Join(" ", a));