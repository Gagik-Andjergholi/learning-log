int t = int.Parse(Console.ReadLine());
int n;
while(t-- > 0)
{
    n = int.Parse(Console.ReadLine());
    if(n % 3 == 0)
        System.Console.WriteLine("Second");
    else
        System.Console.WriteLine("First");
}