int t = int.Parse(Console.ReadLine());
while(t-- > 0){
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    Array.Sort(a);
    System.Console.WriteLine(a[1]);
}