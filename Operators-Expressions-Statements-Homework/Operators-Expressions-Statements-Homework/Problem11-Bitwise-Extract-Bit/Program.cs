using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BitExtract
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        long number = long.Parse(Console.ReadLine());
        long thirdBit = (number >> 3) & 1;
        Console.WriteLine("Third bit is : " + thirdBit);
    }
}

