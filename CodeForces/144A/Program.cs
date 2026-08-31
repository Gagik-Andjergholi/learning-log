using System.Linq;
int n = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
Console.WriteLine(Array.IndexOf(a, a.Max()) +
             n - 1 - Array.LastIndexOf(a, a.Min()) - 
(Array.LastIndexOf(a, a.Min()) < Array.IndexOf(a, a.Max()) ? 1 : 0));