int t = int.Parse(Console.ReadLine());
while(t-- > 0){
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    System.Console.WriteLine(a[1] - a[0]);
}