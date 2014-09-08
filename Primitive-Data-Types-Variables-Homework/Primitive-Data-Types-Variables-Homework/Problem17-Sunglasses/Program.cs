using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SunGlasses
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string frame = new string('*', 2 * n) + new string(' ', n) + new string('*', 2 * n);
        string glass = '*' + new string('/', 2 * n -2) + '*' + new string(' ', n) + '*' + new string('/', 2 * n - 2) + '*';
        string bridge = '*' + new string('/', 2 * n - 2) + '*' + new string('|', n) + '*' + new string('/', 2 * n - 2) + '*';

        Console.WriteLine(frame);
        for (int c = 1; c <= n / 2 - 1; c++)
        {
            Console.WriteLine(glass);
        }
        Console.WriteLine(bridge);
        for (int c = 1; c <= n / 2 - 1; c++)
        {
            Console.WriteLine(glass);
        }
        Console.WriteLine(frame);
    }
}

