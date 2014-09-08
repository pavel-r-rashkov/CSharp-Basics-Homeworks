using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BinaryToDecimalNumber
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        long number = 0;

        for (int i = 0; i < input.Length; i++)
        {
            number += long.Parse(input[i].ToString()) * (long)Math.Pow(2, input.Length - i - 1);
        }
        Console.WriteLine(number);
    }
}

