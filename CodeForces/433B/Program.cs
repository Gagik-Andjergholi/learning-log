int n = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
int[] b =  (int[])a.Clone();
long[] psuma = new long[n + 1];
long[] psumb = new long[n + 1];
int m = int.Parse(Console.ReadLine());
Array.Sort(b);
(psuma[0], psumb[0]) = (0, 0);
for (int i = 1; i <= n; i++)
{
    (psuma[i], psumb[i]) = (psuma[i - 1] + a[i - 1], psumb[i - 1] + b[i - 1]);
}
while(m-- > 0)
{
    int[] query = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Console.WriteLine(query[0] == 1 ? psuma[query[2]] - psuma[query[1] - 1] : psumb[query[2]] - psumb[query[1] - 1]);
}