int t = int.Parse(Console.ReadLine());
while(t-- > 0){
    int[] cin = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    int a = cin[0], b = cin[1];
    System.Console.WriteLine(a <= b ? -1 : a >= 2 * b ? b : a - b);
}