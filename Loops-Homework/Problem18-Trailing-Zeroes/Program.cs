using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TrailingZeroes
{
    static void Main(string[] args)
    {
        long n = long.Parse(Console.ReadLine());
        int numberOfZeroes = 0;

        for (int divider = 5; divider <= n; divider *= 5)
        {
            numberOfZeroes += (int)(n / divider);
        }
        Console.WriteLine(numberOfZeroes);
    }
}

