int[] goozoo = Console.ReadLine().Split().Select(int.Parse).ToArray();
int n = goozoo[0], m = goozoo[1];
int[] a = new int[n];
if(m == 0 && n == 1) {
    Console.WriteLine(0 + " " + 0);
    return;
}
if(!(1 <= m && m <= 9 * n)) {
    Console.WriteLine(-1 + " " + -1);
    return;
}
for(int i = 0; i < n; i++) {
    if(m >= 9) {
        a[i] = 9;
        m -= 9;
    } else {
        a[i] = m;
        m = 0;
    }
}
string s = string.Join("", a) + " ";
Array.Reverse(a);
if(a[0] == 0)
{
    for(int i = 1; i < n; i++) {
        if(a[i] > 0) {
            a[i]--;
            a[0]++;
            break;
        }
    }
}
Console.Write(string.Join("", a) + " ");
System.Console.WriteLine(s);