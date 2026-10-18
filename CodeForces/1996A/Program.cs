int t = int.Parse(Console.ReadLine());
int n;
while(t-- > 0){
    n = int.Parse(Console.ReadLine());
    System.Console.WriteLine(n / 4 + (n % 4) / 2);
}