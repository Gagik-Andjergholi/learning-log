int t = int.Parse(Console.ReadLine());
int n, two, three;
while(t-- > 0){
    n = int.Parse(Console.ReadLine());
    (two, three) = (0, 0);
    while(n % 2 == 0)
    {
        n /= 2;
        two++;
    }
    while(n % 3 == 0)
    {
        n /= 3;
        three++;
    }
    if(n != 1 || two > three)
    {
        System.Console.WriteLine(-1);
        continue;
    }
    System.Console.WriteLine(three * 2 - two);

}