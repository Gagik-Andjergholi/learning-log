int t = int.Parse(Console.ReadLine());
while(t-- > 0){
    int n = int.Parse(Console.ReadLine());
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Array.Sort(a);
    if(n-- <= 2 || (a[0] == a[(n - 1) / 2] && a[n / 2 + 1] == a[n] && (a[n / 2 + 1] == a[n / 2] || a[n / 2] == a[(n - 1) / 2])))
    {
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");        
    }
}