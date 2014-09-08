using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class DecimalToBinaryNumber
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
            output.Append(input % 2);
            input /= 2;
        }

        for (int i = output.Length - 1; i >= 0; i--)
        {
            Console.Write(output[i]);
        }
        Console.WriteLine();
    }
}

