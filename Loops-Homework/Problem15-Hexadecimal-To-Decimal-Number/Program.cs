using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class HexadecimalToDecimalNumber
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        long number = 0;

        for (int i = 0; i < input.Length; i++)
        {
            int digit;
            if (!int.TryParse(input[i].ToString(), out digit))
            {
                digit = (int)input[i] - 55;
            }
            number += digit * (long)Math.Pow(16, input.Length - i - 1);
        }
        Console.WriteLine(number);  
    }
}

