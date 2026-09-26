int t = int.Parse(Console.ReadLine());

while (t-- > 0) {
    int n = int.Parse(Console.ReadLine());
    string s = Console.ReadLine();

    int balance = 0, ans = 0;

    for (int i = 0; i < n; i++) {
        if (s[i] == '(')
            balance++;
        else if (balance > 0)
            balance--;
        else
            ans++;
    }

    Console.WriteLine(ans);
}