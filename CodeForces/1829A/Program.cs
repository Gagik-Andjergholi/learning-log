using System;

class Program
{
    static void Main()
    {
        string target = "codeforces";
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            string s = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < 10; i++)
            {
                if (s[i] != target[i]) count++;
            }
            Console.WriteLine(count);
        }
    }
}