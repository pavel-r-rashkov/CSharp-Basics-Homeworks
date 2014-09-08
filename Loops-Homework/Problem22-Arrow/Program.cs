using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Arrow
{
    static void Main(string[] args)
    {
        char dot = '.';
        char sharp = '#';
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine(new string(dot, n / 2) + new string(sharp, n) + new string(dot, n / 2));

        for (int i = 0; i < n - 2; i++)
        {
            Console.WriteLine(new string(dot, n / 2) + sharp + new string(dot, n - 2) + sharp + new string(dot, n / 2));
        }

        Console.WriteLine(new string(sharp, n / 2 + 1) + new string(dot, n - 2) + new string(sharp, n / 2 + 1));

        for (int i = 1; i < n - 1; i++)
        {
            Console.WriteLine(new string(dot, i) + sharp + new string(dot, 2 * n - 3 - 2 * i) + sharp + new string(dot, i));
        }

        Console.WriteLine(new string(dot, n - 1) + sharp + new string(dot, n - 1));
    }
}

