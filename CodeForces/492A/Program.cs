int n = int.Parse(Console.ReadLine());
for(int i = 1; i < n + 5; i++)
{
    if(i * (i + 1) * (i + 2) / 6 > n)
    {
        Console.WriteLine(i - 1);
        return;
    }
}

//1, 3 , 6 , 10, 15, 21, 28, 36
//1, 4, 10, 20, 35, 56

/*
1
1 2
1 2 3
1 2 3 4
1 2 3 4 5
...
1 2 3 4 5 ... k


k * 1 + (k - 1) * 2 + (k - 2) * 3 + ... + 1 * k = 

S(i * (k - i + 1)) = C(k + 2, 3)
*/