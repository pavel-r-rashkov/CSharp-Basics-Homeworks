using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToHexadecimalNumber
{
    static void Main(string[] args)
    {
        StringBuilder output = new StringBuilder();
        long input = long.Parse(Console.ReadLine());

        if (input == 0)
        {
            output.Append(0);
        }

        while (input != 0)
        {
            if (input % 16 < 10)
            {
                output.Append(input % 16);
            }
            else
            {
                output.Append((char)((input % 16) + 55));
            }
            input /= 16;
        }

        for (int i = output.Length - 1; i >= 0; i--)
        {
            Console.Write(output[i]);
        }
        Console.WriteLine();
    }
}

