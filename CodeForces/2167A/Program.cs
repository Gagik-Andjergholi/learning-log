int t = int.Parse(Console.ReadLine());
while(t-- > 0){
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    bool b = a[0] == a[1] && a[1] == a[2] && a[2] == a[3];
    System.Console.WriteLine(b ? "YES" : "NO");
}