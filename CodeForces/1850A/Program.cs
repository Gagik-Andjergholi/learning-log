int t = int.Parse(Console.ReadLine());
int n;
while(t-- > 0){
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Array.Sort(a);
    System.Console.WriteLine(a[1] + a[2] >= 10 ? "YES" : "NO");
}