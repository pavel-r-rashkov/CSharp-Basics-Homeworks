using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ModifyBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        long number = long.Parse(Console.ReadLine());
        Console.WriteLine("Enter position: ");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter bit value: ");
        long bitValue = long.Parse(Console.ReadLine());
        Console.WriteLine(bitValue == 0 ? ~(1 << position) & number : 1 << position | number);
    }
}

