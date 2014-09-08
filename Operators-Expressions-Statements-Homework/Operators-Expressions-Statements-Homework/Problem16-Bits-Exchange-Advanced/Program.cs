using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitsExchangeAdvanced
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter p: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter q: ");
        int q = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter k: ");
        int k = int.Parse(Console.ReadLine());

        int numberLenght = (int)Math.Log(number, 2) + 1;

        if (p + k - 1 >= numberLenght || q + k - 1 >= numberLenght)
        {
            Console.WriteLine("out of range");
        }
        else if ((q >= p && p + k - 1 >= q) || (p >= q && q + k - 1 >= p))
        {
            Console.WriteLine("overlaping");
        }
        else
        {
            for (int i = p, j = q; i < p + k; i++, j++)
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
}

