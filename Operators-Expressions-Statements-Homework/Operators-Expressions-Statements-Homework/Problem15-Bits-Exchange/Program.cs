using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitsExchange
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        long number = long.Parse(Console.ReadLine());

        for (int i = 3, j = 24; i <= 5; i++, j++)
        {
            long bitI = number >> i & 1;
            long bitJ = number >> j & 1;
            if (bitI == 0)
            {
                number = ~(1 << j) & number;
            }
            else
            {
                number = 1 << j | number;
            }
            if (bitJ == 0)
            {
                number = ~(1 << i) & number;
            }
            else
            {
                number = 1 << i | number;
            }
        }
        Console.WriteLine(number);
    }
}

