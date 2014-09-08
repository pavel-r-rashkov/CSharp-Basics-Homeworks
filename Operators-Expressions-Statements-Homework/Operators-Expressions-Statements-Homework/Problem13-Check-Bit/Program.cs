using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CheckBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        long bit = (number >> position) & 1;
        Console.WriteLine("The bit at position {0} is : {1}", position, bit);
    }
}

