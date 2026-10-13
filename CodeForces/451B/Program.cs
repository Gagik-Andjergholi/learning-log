int n = int.Parse(Console.ReadLine());
int[] a = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

int l = 0, r = n - 1;
bool first = false, second = false, all = true;

for(int i = 0; i < n - 1; i++)
{
    if(a[i] < a[i + 1])
    {
        all = false;
        break;
    }
}
if (all)
{
    System.Console.WriteLine($"yes\n{1} {n}");
    return;
}
all = true;
for(int i = 0; i < n - 1; i++)
{
    if(!first && a[i] > a[i + 1])
    {
        l = i;
        first = true;
        continue;
    }
    if(first && !second && a[i] < a[i + 1])
    {
        if(a[l] > a[i + 1] || (l > 0 && a[l - 1] > a[i]))
        {
            all = false;
            break;
        }
        second = true;
        r = i;
        continue;
    }
    if(first && second && a[i] > a[i + 1])
    {
        all = false;
        break;
    }
}
if (!all || (first && !second && a[l - 1] > a[n - 1]))
{
    System.Console.WriteLine("no");
    return;
}
if(!first){
    System.Console.WriteLine("yes\n" + 1 + " " + 1);
    return;
}
System.Console.WriteLine("yes\n" + (l + 1) + " " + (r + 1));
return;