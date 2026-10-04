int t = int.Parse(Console.ReadLine());
while(t-- > 0)
{
    int n = int.Parse(Console.ReadLine());
    int[] a = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    Console.WriteLine(a[0] == 1 ? "YES" : "NO");
}
/*

*/