int n = int.Parse(Console.ReadLine());
int ans = 0;
string s;
while(n-- > 0)
{
    s = Console.ReadLine();
    switch (s)
    {
        case "Tetrahedron":
            ans += 4;
            break;
        case "Cube":
            ans += 6;
            break;
        case "Octahedron":
            ans += 8;
            break;
        case "Dodecahedron":
            ans += 12;
            break;
        default:
            ans += 20;
            break;
    }
}
System.Console.WriteLine(ans);