using System;

class NewHouse
{
    static void Main(string[] args)
    {
        char dash = '-';
        char asterisk = '*';
        char wall = '|';
        int n = int.Parse(Console.ReadLine());
        for (int dashCount = n / 2, asteriskCount = 1; dashCount >= 0; dashCount--, asteriskCount += 2)
        {
            Console.WriteLine(new string(dash, dashCount) + new string(asterisk, asteriskCount) + new string(dash, dashCount));
        }
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine(wall + new string(asterisk, n - 2) + wall);
        }
    }
}

