int t = int.Parse(Console.ReadLine());
while(t-- > 0){
    int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    System.Console.WriteLine((a[2] + 1) / 2 + a[0] > a[2] / 2 + a[1] ? "First" : "Second");
}