int[] a =
{
  2,3,5,7,11,13,17,19,23,29,31,37,41,43,47,53  
};
int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
for(int i = 0; i < 16; i++)
{
    if(input[0] == a[i])
    {
        input[0] = i + 1;
        break;
    }
}
if(input[1] == a[input[0]])
{
    System.Console.WriteLine("YES");
}
else
{
    System.Console.WriteLine("NO");
}